CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Score INT NOT NULL
);

INSERT INTO Students (StudentID, Name, Score)
VALUES
(1, 'Alice', 95),
(2, 'Bob', 87),
(3, 'Charlie', 73),
(4, 'Diana', 65),
(5, 'Eve', 58),
(6, 'Frank', 90),
(7, 'Grace', 80),
(8, 'Hank', 72),
(9, 'Ivy', 69),
(10, 'Jack', 55);

SELECT * FROM Students;

SELECT 
    Name,
    Score,
    CASE 
        WHEN Score BETWEEN 90 AND 100 THEN 'A'
        WHEN Score BETWEEN 80 AND 89 THEN 'B'
        WHEN Score BETWEEN 70 AND 79 THEN 'C'
        WHEN Score BETWEEN 60 AND 69 THEN 'D'
        ELSE 'F'
    END AS GradeLevel
FROM Students
ORDER BY 
    CASE 
        WHEN Score BETWEEN 90 AND 100 THEN 1
        WHEN Score BETWEEN 80 AND 89 THEN 2
        WHEN Score BETWEEN 70 AND 79 THEN 3
        WHEN Score BETWEEN 60 AND 69 THEN 4
        ELSE 5
    END, -- Order GradeLevel descending by assigning numbers
    Score DESC; -- Within the same grade, order by Score descending



-Example 3

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);
INSERT INTO Products (ProductID, ProductName, Price)
VALUES
(1, 'Laptop', 1200),
(2, 'Smartphone', 800),
(3, 'Headphones', 300),
(4, 'Monitor', 600),
(5, 'Keyboard', 150),
(6, 'Tablet', 950),
(7, 'Mouse', 50),
(8, 'Printer', 400),
(9, 'Gaming Console', 1100),
(10, 'Smartwatch', 750);

SELECT * FROM Products;

SELECT ProductName,Price,
CASE 
	WHEN Price >=1000 THEN 'Premium'
	WHEN Price BETWEEN 500 AND 999 THEN 'STANDARD'
	WHEN Price<500 THEN 'Budget'
END AS Category
FROM Products
ORDER BY 
   CASE
		WHEN Price >=1000 THEN 1
		WHEN Price BETWEEN 500 AND 999 THEN 2
		WHEN Price<500 THEN 3
	END,Price ASC
	