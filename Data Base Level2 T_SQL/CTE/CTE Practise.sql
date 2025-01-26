--Task 1: Calculate Total Sales for Each Product
--Create a CTE to calculate the total sales (Quantity * Price) for each product and list only those with total sales above $10,000.
WITH TotalSales AS
(
    SELECT ProductID, ProductName, Price, Quantity, TotalSales = Price * Quantity 
    FROM Products
)
SELECT * 
FROM TotalSales 
WHERE TotalSales > 10000;



--Task 2: Find Departments with More Than 10 Employees
--Use a CTE to group employees by department and find departments with more than 10 employees.
WITH NumberOfEmployeeInDepartment AS
(
    SELECT Department, COUNT(*) AS NumberOfEmployee 
    FROM Employees 
    GROUP BY Department 
)
SELECT * 
FROM NumberOfEmployeeInDepartment 
WHERE NumberOfEmployee > 10;




--Task 3: Recursive Query for Parent-Child Relationships
--Write a CTE to retrieve a folder structure hierarchy for a given root folder ID.
WITH FolderHierarchy AS
(
    SELECT 
        FolderID, 
        FolderName, 
        ParentFolder, 
        CAST(FolderName AS VARCHAR(MAX)) AS Hierarchy, 
        Level = 0 
    FROM RootTable 
    WHERE Parent IS NULL

    UNION ALL

    SELECT 
        rt.FolderID, 
        rt.FolderName, 
        rt.ParentFolder, 
        CAST(fh.Hierarchy + '->' + rt.FolderName AS VARCHAR(MAX)), 
        fh.Level + 1 AS Level 
    FROM RootTable rt 
    INNER JOIN FolderHierarchy fh ON rt.ParentFolder = fh.FolderID
)
SELECT * 
FROM FolderHierarchy;



--Task 4: Identify High-Selling Categories
--Create a CTE to identify product categories with average product prices above $50.
WITH CategoryAverage AS
(
    SELECT 
        CategoryID, 
        AVG(Price) AS AveragePrice 
    FROM Products 
    GROUP BY CategoryID
)
SELECT CategoryID, AveragePrice 
FROM CategoryAverage 
WHERE AveragePrice > 50;



--Task 1: Find Employees Who Earn Above the Average Salary
--Create a CTE to calculate the average salary for all employees and list employees whose salaries exceed the average.
WITH EmployeeAverage AS 
(
SELECT  AVG(Salary) AS AverageSalary FROM Employees
)
SELECT EmployeeID, Name, Department, Salary 
FROM Employees e, EmployeeAverage empAvg 
WHERE e.Salary > empAvg.AverageSalary;





--Task 2: Recursive Query for Organizational Chart
--Write a recursive CTE to display an organizational chart starting from the CEO, showing each employee's hierarchy level.
WITH EmployeeHierarchiTree AS 
(
SELECT EmployeeID, EmployeeName, Salary, ManagerID, CAST(EmployeeName AS VARCHAR(30)) AS Hierarchy, 0 AS LEVEL 
FROM Employees 
WHERE ManagerID IS NULL 

UNION ALL

SELECT e.EmployeeID, e.EmployeeName, e.Salary, e.ManagerID, 
CAST(eht.Hierarchy + '->' + e.EmployeeName AS VARCHAR(MAX)), eht.Level + 1 AS LEVEL 
FROM Employees e 
INNER JOIN EmployeeHierarchiTree eht ON e.ManagerID = eht.EmployeeID
)
SELECT * FROM EmployeeHierarchiTree;




--Task 3: Top Performers in Each Department
--Using a CTE, calculate the rank of employees within each department based on their performance score. Display only the top 2 performers from each department.
WITH RankEmployee AS 
(
SELECT EmployeeID, Name, Salary, Department, 
RANK() OVER (PARTITION BY Department ORDER BY Score DESC) AS Rank 
FROM Employees
)
SELECT EmployeeID, Name, Salary, Department, Rank 
FROM RankEmployee 
WHERE Rank <= 2;



--Task 4: Identify Out-of-Stock Products
--Create a CTE to calculate stock levels for each product and list products that are out of stock (stock level = 0).

WITH OutOfStock AS 
(
SELECT ProductID, ProductName, StockLevel 
FROM Products 
WHERE StockLevel = 0
)
SELECT * FROM OutOfStock;



--Task 5: Yearly Sales Summary
--Create a CTE to group sales data by year and calculate the total sales for each year. Include only years where total sales exceeded $500,000.
WITH YearlySales AS
(
SELECT YEAR(SaleDate) AS SaleYear, SUM(Amount) AS TotalSales 
FROM Sales 
GROUP BY YEAR(SaleDate)
)
SELECT SaleYear, TotalSales 
FROM YearlySales 
WHERE TotalSales > 500000;



--Task 6: Recursive Query for Family Tree
--Write a recursive CTE to trace a family tree starting from a given individual, showing their descendants with generation levels.
WITH FamilyTree AS 
(
SELECT PersonID, PersonName, Age, Sexe, ParentName, 
CAST(ParentName AS VARCHAR(40)) AS Hierarchy
FROM Persons WHERE ParentName IS NULL

UNION ALL

SELECT PersonID, PersonName, Age, Sexe, ParentName, 
CAST(ft.Hierarchy + '->' + PersonName AS VARCHAR(MAX)) 
FROM Persons p  
INNER JOIN FamilyTree ft ON p.ParentName = ft.PersonName
)
SELECT * FROM FamilyTree;


--Task 7: Identify Duplicate Records
--Create a CTE to identify duplicate records in a table based on specific columns (e.g., Name and DateOfBirth). List only the duplicate entries.
WITH DuplicateRecord AS 
(
SELECT Name, COUNT(*) AS DuplicateCount 
FROM Persons 
GROUP BY Name 
HAVING COUNT(*) > 1
)
SELECT p.* 
FROM Persons p 
INNER JOIN DuplicateRecord dr ON p.Name = dr.Name;


--Task 8: Product Profit Margins
--Using a CTE, calculate the profit margin for each product (SellingPrice - CostPrice) and display products with a margin above 20%.



--Task 9: Generate a Sequence of Dates
--Use a recursive CTE to generate a sequence of dates between two given dates, inclusive.



--Task 10: Customer Purchase Frequency
--Create a CTE to calculate the purchase frequency of each customer and list customers who made more than 10 purchases.






