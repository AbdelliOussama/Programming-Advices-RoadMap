CREATE TABLE Employees5
(EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(20) NOT NULL,
Age INT NOT NULL,
Position VARCHAR(50) NOT NULL,
Salary MONEY NOT NULL
);

ALTER PROCEDURE SP_AddEmployee
    @EmployeeID INT OUTPUT,
    @EmployeeName VARCHAR(20),
    @EmployeeAge INT,
    @Position VARCHAR(50),
    @EmployeeSalary MONEY
AS
BEGIN
    BEGIN TRY
        IF (@EmployeeAge > 18 AND @EmployeeSalary > 0)
        BEGIN
            -- Insert the valid record
            INSERT INTO Employees5 (Name, Age, Position, Salary)
            VALUES (@EmployeeName, @EmployeeAge, @Position, @EmployeeSalary);

            -- Get the newly inserted EmployeeID
            SET @EmployeeID = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
            -- Raise an error for invalid inputs
            THROW 50020, 'Wrong Input: Age must be > 18 and Salary > 0. Please validate!', 3;
        END
    END TRY
    BEGIN CATCH
        -- Catch and re-throw any unexpected errors
        THROW;
    END CATCH
END;



DECLARE @EmployeeIDD INT ;
EXEC SP_AddEmployee 
	@EmployeeName = 'Salim',
	@EmployeeAge = 25,
	@Position = 'Mechanical Ingineer',
	@EmployeeSalary = -2000,
	@EmployeeID = @EmployeeIDD OUTPUT;


SELECT @EmployeeIDD AS NewEmployeeID;
