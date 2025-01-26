DECLARE @Students TABLE
(
    StudentID INT,
    Name VARCHAR(50),
    Age INT
);

INSERT INTO @Students VALUES 
(1, 'Alice', 22),
(2, 'Bob', 24),
(3, 'Charlie', 23);

SELECT * FROM @Students;


---EXAMPLE 2

DECLARE @Orders TABLE
(
    OrderID INT,
    ProductName VARCHAR(50),
    Quantity INT
);

DECLARE @Products TABLE
(
    ProductID INT,
    ProductName VARCHAR(50),
    Stock INT
);

INSERT INTO @Orders VALUES (1, 'Laptop', 2), (2, 'Mouse', 5), (3, 'Keyboard', 1);
INSERT INTO @Products VALUES (1, 'Laptop', 10), (2, 'Mouse', 20), (3, 'Keyboard', 15);

SELECT o.OrderID, o.ProductName, o.Quantity, p.Stock
FROM @Orders o
JOIN @Products p ON o.ProductName = p.ProductName;

----Example 3

DECLARE @Sales TABLE
(
    ProductName VARCHAR(50),
    QuantitySold INT
);

INSERT INTO @Sales VALUES ('Laptop', 5), ('Mouse', 15), ('Keyboard', 10);

SELECT ProductName, SUM(QuantitySold) AS TotalSold
FROM @Sales
GROUP BY ProductName;



----Task 4
DECLARE @Employees TABLE
(
    EmployeeID INT,
    Name VARCHAR(50),
    Salary MONEY
);

INSERT INTO @Employees VALUES (1, 'Alice', 5000), (2, 'Bob', 4000), (3, 'Charlie', 4500);

-- Update salaries for all employees
UPDATE @Employees
SET Salary = Salary * 1.1;

SELECT * FROM @Employees;


