--1. Inline Table-Valued Function (ITVF)
--This example creates an ITVF to fetch all employees from a specific department.
CREATE FUNCTION dbo.GetEmployeesByDepartment(@DepartmentID INT)
RETURNS TABLE
AS
RETURN
(
    SELECT EmployeeID, Name, Position, Salary
    FROM Employees
    WHERE DepartmentID = @DepartmentID
);

-- Example Usage
SELECT * FROM dbo.GetEmployeesByDepartment(1);

--2. Multi-Statement Table-Valued Function (MSTVF)
--This example creates an MSTVF to calculate and return employees with their annual salary.
CREATE FUNCTION dbo.GetStudentMore75()
RETURNS @Student75 TABLE
(
    StudentID INT,
    StudentName NVARCHAR(50),
    Subject NVARCHAR(50),
    Grade INT
)
AS
BEGIN
    INSERT INTO @Student75 
    SELECT StudentID, StudentName, Subject, Grade 
    FROM Students 
    WHERE Grade > 75;

    RETURN;
END;

-- Example Usage
SELECT * FROM dbo.GetStudentMore75();


-- Example Usage
SELECT * FROM dbo.GetAnnualSalaries();



--Task1: Create an ITVF to retrieve products within a given price range.

--Input: Two parameters, @MinPrice and @MaxPrice.
--Output: ProductID, ProductName, and Price.

CREATE FUNCTION dbo.GetProductInRange(@MaxPrice MONEY,@MinPrice MONEY)
RETURNS TABLE
AS
RETURN 
(SELECT ProductID,ProductName,Price  FROM Products 
WHERE Price BETWEEN @MinPrice AND @MaxPrice
);

SELECT * FROM dbo.GetProductInRange(4000,5000);

--Task2: Create an MSTVF to list all students who scored above 75% in any subject.

--Input: None.
--Output: StudentID, Name, Subject, and Grade.
CREATE FUNCTION dbo.GetStudentMore75()
RETURNS @Student75 TABLE
(
    StudentID INT,
    StudentName NVARCHAR(50),
    Subject NVARCHAR(50),
    Grade INT
)
AS
BEGIN
    INSERT INTO @Student75 
    SELECT StudentID, StudentName, Subject, Grade 
    FROM Students 
    WHERE Grade > 75;

    RETURN;
END;

-- Example Usage
SELECT * FROM dbo.GetStudentMore75();


--Task3: Create an ITVF to fetch all orders placed within a given date range.

--Input: @StartDate and @EndDate.
--Output: OrderID, CustomerName, and OrderDate.

CREATE FUNCTION dbo.getOrderPlaced(@StartDate DATE,@EndDate DATE)
RETURNS TABLE
AS
RETURN 
(SELECT OrderID,CustomerName,OrderDate FROM Orders WHERE OrderDate BETWEEN @StartDate AND @EndDate)

SELECT * FROM dbo.getOrderPlaced('2023-09-01',GETDATE());


--Task4: Create an MSTVF to calculate the total sales per department.

--Input: None.
--Output: DepartmentID, DepartmentName, and TotalSales.


CREATE FUNCTION dbo.GetTotalSalesPerDepartment()
RETURNS @TSD TABLE
(
    DepartmentID INT,
    DepartmentName NVARCHAR(50),
    TotalSales MONEY
)
AS 
BEGIN 
    INSERT INTO @TSD 
    SELECT DepartmentID, DepartmentName, SUM(Price) AS TotalSales 
    FROM Sales
    GROUP BY DepartmentID, DepartmentName;

    RETURN;
END;

-- Example Usage
SELECT * FROM dbo.GetTotalSalesPerDepartment();


--Task: Create an ITVF to retrieve all employees whose salary is above the average salary in their department.

--Input: None.
--Output: EmployeeID, Name, and Salary.
CREATE FUNCTION dbo.SalaryAboveAvg()
RETURNS TABLE
AS
RETURN 
(
    SELECT EmployeeID, Name, Salary 
    FROM 
    (
        SELECT EmployeeID, Name, Salary, 
               AVG(Salary) OVER(PARTITION BY DepartmentID) AS AvgSalary 
        FROM Employees
    ) AS T
    WHERE Salary > AvgSalary
);

-- Example Usage
SELECT * FROM dbo.SalaryAboveAvg();


--Task6: Create an MSTVF to return the initials and full names of all customers.
--Input: None.
--Output: CustomerID, Initials, and FullName.
CREATE FUNCTION dbo.InitFullName()
RETURNS @Customers TABLE
(
    CustomerID INT,
    Initials NVARCHAR(10),
    FullName NVARCHAR(50)
)
AS 
BEGIN
    INSERT INTO @Customers 
    SELECT 
        CustomerID, 
        LEFT(CustomerName, 1) + '.' + 
        CASE 
            WHEN CHARINDEX(' ', CustomerName) > 0 
            THEN LEFT(SUBSTRING(CustomerName, CHARINDEX(' ', CustomerName) + 1, LEN(CustomerName)), 1) 
            ELSE ''
        END AS Initials, 
        CustomerName AS FullName
    FROM Customers;

    RETURN;
END;

-- Example Usage
SELECT * FROM dbo.InitFullName();




