CREATE TABLE Products1 (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price DECIMAL(10, 2),
    Stock INT,
    Category VARCHAR(50) NULL
);
INSERT INTO Products1 (ProductID, ProductName, Price, Stock)
VALUES
(1, 'Laptop', 1200, 10),
(2, 'Smartphone', 800, 5),
(3, 'Headphones', 300, 0),
(4, 'Monitor', 700, 0),
(5, 'Tablet', 400, 20),
(6, 'Keyboard', 150, 15),
(7, 'Smartwatch', 1200, 0),
(8, 'Gaming Console', 900, 8);


Update Products1
SET Category =
CASE 
	WHEN Price>=1000 THEN
		CASE 
			WHEN Stock >0 THEN 'Premium (In Stock)'
			WHEN Stock = 0 THEN 'Premium (Out of Stock)'
		END
	WHEN Price Between 500 AND 999 THEN
		CASE
			WHEN Stock >0 THEN 'Standard (In Stock)'
			WHEN Stock = 0 THEN 'Standard (Out of Stock)'
		END
	WHEN Price<500 THEN
		CASE
			WHEN Stock >0 THEN 'Budget (In Stock)'
			WHEN Stock = 0 THEN 'Budget (Out of Stock)'
		END
END
				

