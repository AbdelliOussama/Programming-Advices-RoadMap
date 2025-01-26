--1. Log Changes After an Insert
--This trigger logs details of every new employee added to the Employees table into an Audit table.

CREATE TABLE EmployeeAudit (
    AuditID INT IDENTITY PRIMARY KEY,
    EmployeeID INT,
    Name NVARCHAR(50),
    ActionDate DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeID, Name)
    SELECT EmployeeID, Name FROM INSERTED;
END;

--Example 2: AFTER UPDATE Trigger
--This trigger logs salary changes to a salary history table.


CREATE TABLE SalaryHistory (
    HistoryID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID INT,
    OldSalary MONEY,
    NewSalary MONEY,
    ChangeDate DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER trg_AfterUpdate_Salary
ON Employees
AFTER UPDATE
AS
BEGIN
    IF UPDATE(Salary)
    BEGIN
        INSERT INTO SalaryHistory (EmployeeID, OldSalary, NewSalary)
        SELECT d.EmployeeID, d.Salary AS OldSalary, i.Salary AS NewSalary
        FROM DELETED d
        INNER JOIN INSERTED i ON d.EmployeeID = i.EmployeeID;
    END
END;



--Example 3: AFTER DELETE Trigger
--This trigger archives deleted customer records to a backup table.



CREATE TABLE DeletedCustomers (
    CustomerID INT,
    CustomerName NVARCHAR(100),
    DeletedDate DATETIME DEFAULT GETDATE()
);

CREATE TRIGGER trg_AfterDelete_Customers
ON Customers
AFTER DELETE
AS
BEGIN
    INSERT INTO DeletedCustomers (CustomerID, CustomerName)
    SELECT CustomerID, CustomerName FROM DELETED;
END;


--3. Prevent Deletion of Critical Data
--This trigger prevents the deletion of records for users with a specific role.
CREATE TRIGGER trg_AfterDeleteAdmin
ON Users
AFTER DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM DELET
	ED WHERE Role = 'Admin')
    BEGIN
        RAISERROR ('Cannot delete Admin users.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;


--Task 1: AFTER INSERT
--Create an AFTER INSERT trigger on a Products table that logs newly added products to a ProductAudit table.
--The audit table should include ProductID, Action, and ActionDate.
CREATE TABLE ProductAudit 
(
    ProductID INT,
    Action VARCHAR(50),
    ActionDate DATE NOT NULL DEFAULT GETDATE()
);

CREATE TRIGGER trg_AfterAddProduct ON Products
AFTER INSERT
AS 
BEGIN 
    INSERT INTO ProductAudit (ProductID, Action, ActionDate)
    SELECT ProductID, 'Inserted', GETDATE()
    FROM inserted;
END;


--Task 2: AFTER UPDATE
--Write a trigger to track changes to the Price column in a Products table.
--Log the old and new prices into a PriceChangeHistory table.
CREATE TABLE PriceChangeHistory 
(
    ProductID INT,
    ProductName VARCHAR(50),
    NewPrice MONEY,
    OldPrice MONEY,
    ChangeDate DATE DEFAULT GETDATE()
);

CREATE TRIGGER trg_AfterUpdateProduct ON Products
AFTER UPDATE
AS
BEGIN 
    IF UPDATE(Price)
    BEGIN
        INSERT INTO PriceChangeHistory (ProductID, ProductName, NewPrice, OldPrice, ChangeDate)
        SELECT i.ProductID, i.ProductName, i.Price, d.Price, GETDATE()
        FROM inserted i
        INNER JOIN deleted d ON i.ProductID = d.ProductID;
    END;
END;

--Task 3: AFTER DELETE
--Create a trigger to store deleted employee records (including all columns) into an ArchivedEmployees table for reference.
CREATE TABLE ArchivedEmployee
(EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
EmployeeName VARCHAR(30),
Salary MONEY,
Department VARCHAR(20)
);

CREATE TRIGGER trg_AfterDeleteEmployee ON Employees
AFTER DELETE 
AS 
BEGIN 
	INSERT INTO ArchivedEmployee
	SELECT * FROM deleted
END
--Task 4: Multi-Action Trigger
--Develop a single AFTER trigger that handles INSERT, UPDATE, and DELETE actions on an Orders table.
--Log these actions into an OrderAudit table with columns OrderID, ActionType, and ActionDate.
CREATE TABLE OrderAudit 
(
    OrderID INT,
    ActionType VARCHAR(50),
    ActionDate DATE NOT NULL DEFAULT GETDATE()
);

CREATE TRIGGER trg_AfterInsertUpdateDeleteOrder ON Orders
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN 
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO OrderAudit (OrderID, ActionType, ActionDate)
        SELECT OrderID, 'Inserted', GETDATE()
        FROM inserted;
    END
    ELSE IF EXISTS (SELECT 1 FROM deleted) AND EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO OrderAudit (OrderID, ActionType, ActionDate)
        SELECT OrderID, 'Updated', GETDATE()
        FROM inserted;
    END
    ELSE IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO OrderAudit (OrderID, ActionType, ActionDate)
        SELECT OrderID, 'Deleted', GETDATE()
        FROM deleted;
    END
END;



--Task 5: Validation with AFTER Trigger
--Write an AFTER INSERT trigger on a Transactions table to validate that the Amount column is not negative.
--If a negative amount is detected, roll back the transaction and raise an error using ROLLBACK TRAN.
CREATE TABLE TransactionLog 
(
    TransactionID INT,
    Amount MONEY,
    TransactionDate DATE DEFAULT GETDATE()
);

CREATE TRIGGER trg_ValidateTransaction ON Transactions
AFTER INSERT 
AS 
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE Amount < 0)
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('Negative amount is not allowed.', 16, 1);
    END
    ELSE
    BEGIN
        INSERT INTO TransactionLog (TransactionID, Amount, TransactionDate)
        SELECT TransactionID, Amount, GETDATE()
        FROM inserted;
    END;
END;



