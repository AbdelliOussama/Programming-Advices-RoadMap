CREATE TABLE Employees4 (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(50),
    Department VARCHAR(50),
    HireDate DATE
);

CREATE PROCEDURE AddEmployee
    @EmployeeName VARCHAR(50),
    @Department VARCHAR(50),
    @HireDate DATE,
    @NewEmployeeID INT OUTPUT
AS
BEGIN
    INSERT INTO Employees4 (EmployeeName, Department, HireDate)
    VALUES (@EmployeeName, @Department, @HireDate);

    SET @NewEmployeeID = SCOPE_IDENTITY();
END;

DECLARE @NewID INT;
EXEC AddEmployee 
'John Doe', 
'IT',
GETDATE()
, @NewID OUTPUT;
PRINT 'New Employee ID: ' + CAST(@NewID AS VARCHAR);
