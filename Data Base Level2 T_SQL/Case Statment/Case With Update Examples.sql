CREATE TABLE Employees1 (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    PerformanceRating INT NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL
);
INSERT INTO Employees1 (EmployeeID, Name, PerformanceRating, Salary)
VALUES
(1, 'Alice', 5, 5000.00),
(2, 'Bob', 4, 4500.00),
(3, 'Charlie', 3, 4000.00),
(4, 'Diana', 2, 3500.00),
(5, 'Eve', 1, 3000.00),
(6, 'Frank', 5, 5200.00),
(7, 'Grace', 4, 4700.00),
(8, 'Hank', 3, 4100.00),
(9, 'Ivy', 2, 3600.00),
(10, 'Jack', 1, 2800.00);

Update Employees1 
SET Salary =
CASE PerformanceRating
	WHEN 5 THEN Salary*1.2
	WHEN 4 THEN Salary*1.15
	WHEN 3 THEN Salary*1.1
	WHEN 2 THEN Salary
	WHEN 1 THEN Salary*0.9
END


CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Score INT NOT NULL,
    Grade VARCHAR(2) NULL
);

INSERT INTO Students (StudentID, Name, Score)
VALUES
(1, 'Alice', 95),
(2, 'Bob', 85),
(3, 'Charlie', 75),
(4, 'Diana', 65),
(5, 'Eve', 55),
(6, 'Frank', 90),
(7, 'Grace', 80),
(8, 'Hank', 70),
(9, 'Ivy', 60),
(10, 'Jack', 50);

UPDATE Students 
SET Grade = 
CASE
	WHEN Score>=90 THEN 'A'
	WHEN Score between 80 AND 89 THEN 'B'
	WHEN Score between 70 AND 79 THEN 'C'
	WHEN Score between 60 AND 69 THEN 'D'
	ELSE
		'F'
END


CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerName VARCHAR(50) NOT NULL,
    OrderDate DATE NOT NULL,
    DeliveryDate DATE NOT NULL,
    Status VARCHAR(20) NULL
);
INSERT INTO Orders (OrderID, CustomerName, OrderDate, DeliveryDate)
VALUES
(1, 'Alice', '2024-11-15', '2024-11-20'),
(2, 'Bob', '2024-11-16', '2024-11-22'),
(3, 'Charlie', '2024-11-17', '2024-11-23'),
(4, 'Diana', '2024-11-18', '2024-11-24'),
(5, 'Eve', '2024-11-19', '2024-11-25'),
(6, 'Frank', '2024-11-20', '2024-11-21');


SELECT * FROM Orders; 

UPDATE Orders
SET Status = 
CASE 
    WHEN DeliveryDate < GETDATE() THEN 'Delivered'
    WHEN DeliveryDate = GETDATE() THEN 'Out for Delivery'
    WHEN DeliveryDate > GETDATE() THEN 'Pending'
END;
