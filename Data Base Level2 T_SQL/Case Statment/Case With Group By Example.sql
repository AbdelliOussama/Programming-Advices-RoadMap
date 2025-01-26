CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    CustomerName VARCHAR(50),
    ProductName VARCHAR(50),
    Amount DECIMAL(10, 2)
);


INSERT INTO Sales (SaleID, CustomerName, ProductName, Amount)
VALUES
(1, 'Alice', 'Laptop', 1200),
(2, 'Bob', 'Smartphone', 800),
(3, 'Charlie', 'Headphones', 300),
(4, 'Diana', 'Tablet', 600),
(5, 'Edward', 'Keyboard', 150),
(6, 'Frank', 'Monitor', 1100),
(7, 'Grace', 'Smartwatch', 450),
(8, 'Hannah', 'Gaming Console', 950);

SELECT Category, TotalSales = SUM(Amount),NumberOfSales = COUNT(*) FROM
(SELECT Amount ,ProductName ,Category = 
CASE 
	WHEN Amount<500 THEN 'LOW'
	WHEN Amount BETWEEN 500 AND 1000 THEN 'Medium'
	WHEN Amount>1000 THEN 'HIGH'
END
FROM  Sales)AS SALETABLE  
GROUP BY Category
ORDER BY
	CASE 
		WHEN Category = 'LOW' THEN 1
		WHEN Category = 'Medium' THEN 2
		WHEN Category = 'HIGH' THEN 3
	END

	CREATE TABLE Employees2 (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
    DateOfBirth DATE,
    Department VARCHAR(50)
);
INSERT INTO Employees2 (EmployeeID, EmployeeName, DateOfBirth, Department)
VALUES
(1, 'Alice', '1995-03-10', 'IT'),
(2, 'Bob', '1980-06-22', 'Sales'),
(3, 'Charlie', '1965-09-15', 'HR'),
(4, 'Diana', '1990-01-05', 'IT'),
(5, 'Edward', '1975-11-10', 'Finance'),
(6, 'Frank', '1955-04-12', 'Sales'),
(7, 'Grace', '1988-07-22', 'HR'),
(8, 'Hannah', '1997-02-14', 'Finance');

SELECT * FROM Employees2;



SELECT Category,COUNT(*) AS TOTALEMPLOYEES,AVG(AGE) AS AGEAVERAGE,Department
FROM
(SELECT *,Category =
CASE 
	WHEN AGE <30 THEN 'YOUNG'
	WHEN AGE BETWEEN 30 AND 50 THEN 'EXPERIENCED'
	WHEN AGE>50 THEN 'SENIOR'
END
FROM
(SELECT EmployeeName,Department,DateOfBirth,DATEDIFF(YEAR,DateOfBirth,GETDATE()) AS AGE
FROM Employees2)AS EMP)AS EMP2
GROUP BY Category,Department
ORDER BY 
	CASE 
		WHEN Category = 'YOUNG' THEN 1
		WHEN Category ='EXPERIENCED' THEN 2
		WHEN Category ='SENIOR' THEN 3
	END
,Department ASC	



CREATE TABLE Sales1 (
    SalesID INT PRIMARY KEY,
    EmployeeName VARCHAR(50),
    Amount DECIMAL(10, 2),
    Region VARCHAR(50),
    SaleDate DATE
);

INSERT INTO Sales1 (SalesID, EmployeeName, Amount, Region, SaleDate)
VALUES
(1, 'Alice', 1200, 'North', '2024-11-01'),
(2, 'Bob', 700, 'South', '2024-10-15'),
(3, 'Charlie', 300, 'West', '2024-08-20'),
(4, 'Diana', 1500, 'North', '2024-09-30'),
(5, 'Edward', 800, 'East', '2024-11-10'),
(6, 'Frank', 450, 'South', '2024-06-01'),
(7, 'Grace', 2500, 'West', '2024-11-18'),
(8, 'Hannah', 950, 'East', '2024-07-25');



SELECT Category,AGECATEGORY,Region,TotalSales = COUNT(*),TotalAmount = SUM(Amount)
FROM
	(SELECT * ,
	CASE 
		WHEN AGE <30 THEN 'RECENT'
		WHEN AGE BETWEEN 30 AND 90  THEN 'OLDER'
		WHEN AGE>90 THEN 'ARCHIVED'
	END AS AGECATEGORY FROM
	(SELECT *,Category = 
	CASE 
		WHEN Amount<500 THEN 'LOW'
		WHEN Amount BETWEEN 500 AND 1000 THEN 'MEDIUM'
		WHEN Amount>1000 THEN 'HIGH'
	END,AGE = DATEDIFF(MONTH,SaleDate,GETDATE())
	FROM Sales1
) AS SALE) AS TableSales
GROUP BY AGECATEGORY,Region,Category
ORDER BY 
	CASE 
		WHEN Category  = 'HIGH' THEN 1
		WHEN Category  = 'MEDIUM' THEN 2
		WHEN Category  = 'LOW' THEN 3
	END,Region