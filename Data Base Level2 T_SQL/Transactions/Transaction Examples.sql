-- Task 1
CREATE TABLE BankAccounts
(AccountID INT IDENTITY(1,1) PRIMARY KEY ,
AccountHolder VARCHAR(30) NOT NULL,
Balance MONEY NOT NULL
)
CREATE TABLE TransactionLog(
TransactionID INT IDENTITY(1,1) PRIMARY KEY,
TransactionDate Date NOT NULL,
TansactionAmount MONEY NOT NULL ,
TransactionStatus VARCHAR(30)
);
INSERT INTO BankAccounts VALUES
('SEnder', 9000),
('Reciver',100);

SELECT * FROM BankAccounts
DECLARE @SenderBalance MONEY;
DECLARE @SenderAccount VARCHAR(30) = 'SEnder';
DECLARE @ReceiverAccount VARCHAR(30) = 'Reciver';
DECLARE @TransferAmount MONEY = 500;

BEGIN TRANSACTION
	BEGIN TRY 	
		SELECT  @SenderBalance = Balance FROM BankAccounts WHERE AccountHolder = @SenderAccount
		IF EXISTS (SELECT AccountHolder from BankAccounts WHERE AccountHolder IN (@ReceiverAccount,@SenderAccount))
			IF @SenderBalance <500
				THROW 50001,'Insufissant Solde',4;
			UPDATE BankAccounts SET Balance = Balance - @TransferAmount  WHERE AccountHolder = @SenderAccount;
			UPDATE BankAccounts SET Balance = Balance +@TransferAmount WHERE AccountHolder = @ReceiverAccount;
			INSERT INTO TransactionLog VALUES(GETDATE(),@TransferAmount,'Completed');
			COMMIT 
	END TRY 
	BEGIN CATCH
		ROLLBACK
		SELECT ERROR_MESSAGE() AS ErrorMsg;
	END CATCH

	SELECT * FROM BankAccounts
	SELECT * FROM TransactionLog;

----TASK 2
CREATE TABLE Inventory (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    Price MONEY NOT NULL
);

CREATE TABLE SalesLog (
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    ItemID INT NOT NULL,
    QuantitySold INT NOT NULL,
    SaleDate DATETIME NOT NULL,
    TotalAmount MONEY NOT NULL
);

-- Insert initial inventory data
INSERT INTO Inventory (ItemName, Quantity, Price)
VALUES ('Laptop', 10, 1500), ('Mouse', 50, 20), ('Keyboard', 30, 45);

-- Sale transaction
DECLARE @ItemID INT = 1; -- Example: Laptop
DECLARE @QuantitySold INT = 2;

BEGIN TRANSACTION;
BEGIN TRY
    DECLARE @AvailableQuantity INT;
    DECLARE @ItemPrice MONEY;
    
    SELECT @AvailableQuantity = Quantity, @ItemPrice = Price
    FROM Inventory WHERE ItemID = @ItemID;

    -- Check if enough stock is available
    IF @AvailableQuantity < @QuantitySold
        THROW 60001, 'Insufficient stock for the sale.', 5;

    -- Deduct from inventory
    UPDATE Inventory
    SET Quantity = Quantity - @QuantitySold
    WHERE ItemID = @ItemID;

    -- Log the sale
    INSERT INTO SalesLog (ItemID, QuantitySold, SaleDate, TotalAmount)
    VALUES (@ItemID, @QuantitySold, GETDATE(), @QuantitySold * @ItemPrice);

    COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
    SELECT ERROR_MESSAGE() AS ErrorMsg;
END CATCH;

-- Check inventory and sales log
SELECT * FROM Inventory;
SELECT * FROM SalesLog;



---TASK 3
CREATE TABLE Warehouses (
    WarehouseID INT IDENTITY(1,1) PRIMARY KEY,
    WarehouseName VARCHAR(50) NOT NULL
);

CREATE TABLE WarehouseInventory (
    WarehouseID INT,
    ItemID INT,
    Quantity INT,
    PRIMARY KEY (WarehouseID, ItemID)
);

-- Insert sample data
INSERT INTO Warehouses (WarehouseName) VALUES ('Main Warehouse'), ('Backup Warehouse');
INSERT INTO WarehouseInventory (WarehouseID, ItemID, Quantity)
VALUES (1, 1, 10), (2, 1, 5);

-- Transfer transaction
DECLARE @FromWarehouse INT = 1; -- Main Warehouse
DECLARE @ToWarehouse INT = 2; -- Backup Warehouse
DECLARE @ItemID INT = 1; -- Example: Laptop
DECLARE @TransferQuantity INT = 2;

BEGIN TRANSACTION;
BEGIN TRY
    DECLARE @AvailableQuantity INT;

    SELECT @AvailableQuantity = Quantity
    FROM WarehouseInventory
    WHERE WarehouseID = @FromWarehouse AND ItemID = @ItemID;

    -- Check if the source warehouse has enough quantity
    IF @AvailableQuantity < @TransferQuantity
        THROW 60002, 'Not enough inventory in source warehouse.', 5;

    -- Deduct from source warehouse
    UPDATE WarehouseInventory
    SET Quantity = Quantity - @TransferQuantity
    WHERE WarehouseID = @FromWarehouse AND ItemID = @ItemID;

    -- Add to destination warehouse
    IF EXISTS (SELECT 1 FROM WarehouseInventory WHERE WarehouseID = @ToWarehouse AND ItemID = @ItemID)
        UPDATE WarehouseInventory
        SET Quantity = Quantity + @TransferQuantity
        WHERE WarehouseID = @ToWarehouse AND ItemID = @ItemID;
    ELSE
        INSERT INTO WarehouseInventory (WarehouseID, ItemID, Quantity)
        VALUES (@ToWarehouse, @ItemID, @TransferQuantity);

    COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
    SELECT ERROR_MESSAGE() AS ErrorMsg;
END CATCH;

-- Check warehouse inventories
SELECT * FROM WarehouseInventory;



---TASK 4
CREATE TABLE Employees4 (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(50) NOT NULL,
    Salary MONEY NOT NULL
);

CREATE TABLE PayrollLog (
    PayrollID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT NOT NULL,
    SalaryPaid MONEY NOT NULL,
    Deduction MONEY NOT NULL,
    PaymentDate DATETIME NOT NULL
);

-- Insert initial data
INSERT INTO Employees (EmployeeName, Salary) VALUES ('John Doe', 3000), ('Jane Smith', 2500);

-- Payroll transaction
DECLARE @EmployeeID INT = 1; -- Example: John Doe
DECLARE @Deduction MONEY = 200;

BEGIN TRANSACTION;
BEGIN TRY
    DECLARE @Salary MONEY;

    SELECT @Salary = Salary FROM Employees WHERE EmployeeID = @EmployeeID;

    -- Deduct from salary and log the payroll
    INSERT INTO PayrollLog (EmployeeID, SalaryPaid, Deduction, PaymentDate)
    VALUES (@EmployeeID, @Salary - @Deduction, @Deduction, GETDATE());

    COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
    SELECT ERROR_MESSAGE() AS ErrorMsg;
END CATCH;

-- Check payroll log
SELECT * FROM PayrollLog;



--TASK 5*
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(50) NOT NULL,
    TotalAmount MONEY NOT NULL
);

CREATE TABLE Refunds (
    RefundID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    RefundAmount MONEY NOT NULL,
    RefundDate DATETIME NOT NULL
);

-- Insert sample orders
INSERT INTO Orders (CustomerName, TotalAmount)
VALUES ('Alice', 500), ('Bob', 300);

-- Refund transaction
DECLARE @OrderID INT = 1; -- Example: Alice's order
DECLARE @RefundAmount MONEY = 200;

BEGIN TRANSACTION;
BEGIN TRY
    DECLARE @OrderTotal MONEY;

    SELECT @OrderTotal = TotalAmount FROM Orders WHERE OrderID = @OrderID;

    -- Ensure refund amount does not exceed total amount
    IF @RefundAmount > @OrderTotal
        THROW 60003, 'Refund amount exceeds total order value.', 5;

    -- Log the refund
    INSERT INTO Refunds (OrderID, RefundAmount, RefundDate)
    VALUES (@OrderID, @RefundAmount, GETDATE());

    COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
    SELECT ERROR_MESSAGE() AS ErrorMsg;
END CATCH;

-- Check orders and refunds
SELECT * FROM Orders;
SELECT * FROM Refunds;



