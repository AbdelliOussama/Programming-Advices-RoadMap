--Scenario: Prevent direct insertion into a Products table and redirect the data to an UnapprovedProducts table for review.

-- UnapprovedProducts Table
CREATE TABLE UnapprovedProducts (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(50),
    Price MONEY
);

-- Products Table
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(50),
    Price MONEY
);

-- INSTEAD OF INSERT Trigger
CREATE TRIGGER trg_InsteadOfInsertProducts
ON Products
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO UnapprovedProducts (ProductName, Price)
    SELECT ProductName, Price
    FROM INSERTED;
END;

-- Example Insert (Will be redirected to UnapprovedProducts)
INSERT INTO Products (ProductName, Price)
VALUES ('New Product', 150);



--Scenario: Restrict updates on the Salary column in an Employees table if the increase is more than 20%.

-- Employees Table
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50),
    Salary MONEY
);

-- INSTEAD OF UPDATE Trigger
CREATE TRIGGER trg_InsteadOfUpdateSalary
ON Employees
INSTEAD OF UPDATE
AS
BEGIN
    UPDATE Employees
    SET Salary = CASE 
                    WHEN INSERTED.Salary <= 1.2 * EMPLOYEES.Salary THEN INSERTED.Salary
                    ELSE EMPLOYEES.Salary
                 END
    FROM Employees
    INNER JOIN INSERTED ON Employees.EmployeeID = INSERTED.EmployeeID;
END;

-- Example Update (Restricts Salary Increase > 20%)
UPDATE Employees
SET Salary = Salary * 1.5
WHERE EmployeeID = 1;


--Scenario: Prevent deletion of records from the Customers table. Instead, mark them as inactive by updating a Status column.

-- Customers Table
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(50),
    Status NVARCHAR(10) DEFAULT 'Active'
);

-- INSTEAD OF DELETE Trigger
CREATE TRIGGER trg_InsteadOfDeleteCustomers
ON Customers
INSTEAD OF DELETE
AS
BEGIN
    UPDATE Customers
    SET Status = 'Inactive'
    WHERE CustomerID IN (SELECT CustomerID FROM DELETED);
END;

-- Example Delete (Will Mark as Inactive Instead)
DELETE FROM Customers
WHERE CustomerID = 2;


--Scenario: Implement a trigger on a Sales view to handle insert, update, and delete operations.



-- Sales View
CREATE VIEW vw_Sales AS
SELECT SaleID, ProductID, Quantity, SaleDate
FROM Sales;

-- INSTEAD OF Trigger
CREATE TRIGGER trg_InsteadOfOperationsOnSales
ON vw_Sales
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        INSERT INTO Sales (ProductID, Quantity, SaleDate)
        SELECT ProductID, Quantity, SaleDate
        FROM INSERTED;
    END

    IF EXISTS (SELECT * FROM DELETED)
    BEGIN
        DELETE FROM Sales
        WHERE SaleID IN (SELECT SaleID FROM DELETED);
    END
END;

-- Example Operations
INSERT INTO vw_Sales (ProductID, Quantity, SaleDate)
VALUES (1, 10, GETDATE());
DELETE FROM vw_Sales WHERE SaleID = 1;







--Task 1: Create an INSTEAD OF INSERT trigger on an Orders table to redirect orders with quantities above a threshold to a PendingOrders table.
CREATE TABLE Orders1
(OrderID INT IDENTITY(1,1) PRIMARY KEY,
OrderName VARCHAR(30),
OrderDate Date,
OrderPrice MONEY,
Quantity INT
)

CREATE TABLE PendingOrders
(OrderID INT IDENTITY(1,1) PRIMARY KEY,
OrderName VARCHAR(30),
OrderDate Date,
OrderPrice MONEY,
Quantity INT
)

CREATE TRIGGER trg_InsertOrder ON Orders1 
INSTEAD OF INSERT 
AS 
BEGIN 
    DECLARE @Threshold INT = 50; -- Set a threshold value (example: 50)

    IF EXISTS (SELECT * FROM INSERTED WHERE Quantity > @Threshold)
    BEGIN
        INSERT INTO PendingOrders (OrderName, OrderDate, OrderPrice, Quantity)
        SELECT OrderName, OrderDate, OrderPrice, Quantity
        FROM INSERTED
        WHERE Quantity > @Threshold;
    END
    ELSE
    BEGIN
        INSERT INTO Orders1 (OrderName, OrderDate, OrderPrice, Quantity)
        SELECT OrderName, OrderDate, OrderPrice, Quantity
        FROM INSERTED
        WHERE Quantity <= @Threshold;
    END
END;



--Task 2: Write an INSTEAD OF UPDATE trigger to prevent changes to the Email column in a Users table. Allow other columns to be updated.
CREATE TABLE User2
(UserID INT IDENTITY(1,1) PRIMARY KEY,
UserName VARCHAR (50),
PassWord VARCHAR(30),
Email VARCHAR(50)
)
CREATE TRIGGER trg_UpdateUser ON User2
INSTEAD OF UPDATE
AS 
BEGIN 
    UPDATE User2
    SET UserName = INSERTED.UserName,
        PassWord = INSERTED.PassWord,
        Email = User2.Email
    FROM User2
    INNER JOIN INSERTED ON User2.UserID = INSERTED.UserID;
END;


--Task 3: Implement an INSTEAD OF DELETE trigger on an Inventory table to move deleted records into an ArchivedInventory table.
CREATE TABLE Inventory1	
(ProductID INT IDENTITY(1,1) PRIMARY KEY,
ProductName VARCHAR(50),
ProductType VARCHAR(50),
Quantity INT,
)
CREATE TABLE ArchivedInventory
(ProductID INT IDENTITY(1,1) PRIMARY KEY,
ProductName VARCHAR(50),
ProductType VARCHAR(50),
Quantity INT,
)
CREATE TRIGGER trg_DeleteInventory ON Inventory1
INSTEAD OF DELETE
AS
BEGIN
    INSERT INTO ArchivedInventory (ProductName, ProductType, Quantity)
    SELECT ProductName, ProductType, Quantity
    FROM DELETED;
END;


--Task 4: Develop a multi-action INSTEAD OF trigger on a Products view to handle all INSERT, UPDATE, and DELETE operations with appropriate logic for each action.
CREATE TRIGGER trg_InsteadOfOperationOnVwProducts ON vw_AllProducts
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    -- Handle INSERT
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        INSERT INTO Products1 (ProductName, ProductType, ProductQuantity)
        SELECT ProductName, ProductType, ProductQuantity
        FROM INSERTED;
    END;

    -- Handle UPDATE
    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
    BEGIN
        UPDATE Products1
        SET ProductName = INSERTED.ProductName,
            ProductType = INSERTED.ProductType,
            ProductQuantity = INSERTED.ProductQuantity
        FROM Products1
        INNER JOIN INSERTED ON Products1.ProductID = INSERTED.ProductID;
    END;

    -- Handle DELETE
    IF EXISTS (SELECT * FROM DELETED)
    BEGIN
        DELETE FROM Products1
        WHERE ProductID IN (SELECT ProductID FROM DELETED);
    END;
END;

--Task 5: Write an INSTEAD OF INSERT trigger on a Transactions table to validate that amounts are not negative before insertion. If negative, redirect the record to an ErrorLog table.
CREATE TRIGGER trg_InsertTransaction ON Transactions
INSTEAD OF INSERT 
AS
BEGIN
    -- Handle Negative Amounts
    IF EXISTS (SELECT * FROM INSERTED WHERE Amount < 0)
    BEGIN
        INSERT INTO ErrorLog 
        SELECT * FROM INSERTED WHERE Amount < 0;
    END;

    -- Handle Valid Transactions
    IF EXISTS (SELECT * FROM INSERTED WHERE Amount >= 0)
    BEGIN
        INSERT INTO Transactions 
        SELECT * FROM INSERTED WHERE Amount >= 0;
    END;
END;

