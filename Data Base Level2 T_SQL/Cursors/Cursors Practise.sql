--Basic Cursor for Reading Data: Print the names of employees one by one.

DECLARE @EmployeeName NVARCHAR(50);
DECLARE emp_cursor CURSOR FOR 
SELECT Name FROM Employees;

OPEN emp_cursor;
FETCH NEXT FROM emp_cursor INTO @EmployeeName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @EmployeeName;
    FETCH NEXT FROM emp_cursor INTO @EmployeeName;
END;

CLOSE emp_cursor;
DEALLOCATE emp_cursor;


--Updating Data Using a Cursor: Increase the salary of employees in a specific department by 10%.

DECLARE @EmployeeID INT, @Salary MONEY;

DECLARE salary_cursor CURSOR FOR 
SELECT EmployeeID, Salary FROM Employees WHERE DepartmentID = 1;

OPEN salary_cursor;

FETCH NEXT FROM salary_cursor INTO @EmployeeID, @Salary;

WHILE @@FETCH_STATUS = 0
BEGIN
    UPDATE Employees
    SET Salary = @Salary * 1.1
    WHERE EmployeeID = @EmployeeID;

    FETCH NEXT FROM salary_cursor INTO @EmployeeID, @Salary;
END;

CLOSE salary_cursor;
DEALLOCATE salary_cursor;




--Task 1: Create a cursor to print all product names in a Products table.

--Input: None.
--Output: ProductName printed row-by-row.

DECLARE @ProductName VARCHAR(30);
DECLARE product_cursor CURSOR STATIC FORWARD_ONLY FOR 
SELECT ProductName FROM Products1;

OPEN product_cursor;

FETCH NEXT FROM product_cursor INTO @ProductName;

WHILE @@FETCH_STATUS = 0 
BEGIN
    PRINT 'ProductName: ' + @ProductName;
    FETCH NEXT FROM product_cursor INTO @ProductName;
END;

CLOSE product_cursor;
DEALLOCATE product_cursor;

	

--Task 2: Use a cursor to update the stock level of products by reducing it by 5% if their stock is greater than 100.
DECLARE @ProductID INT, @ProductName VARCHAR(50), @Price MONEY, @ProductStock INT;
DECLARE prod_cursor CURSOR FOR
SELECT ProductID, ProductName, Price, ProductStock FROM Products;

OPEN prod_cursor;

FETCH NEXT FROM prod_cursor INTO @ProductID, @ProductName, @Price, @ProductStock;

WHILE @@FETCH_STATUS = 0
BEGIN 
    IF @ProductStock > 100
    BEGIN
        UPDATE Products	
        SET ProductStock = @ProductStock * 0.95
        WHERE ProductID = @ProductID;
    END

    FETCH NEXT FROM prod_cursor INTO @ProductID, @ProductName, @Price, @ProductStock;
END;

CLOSE prod_cursor;
DEALLOCATE prod_cursor;


--Task 3: Create a cursor to calculate and display the total sales (quantity * price) for each order in an Orders table.

--Input: None.
--Output: OrderID and TotalSales.
DECLARE @ProductID INT, @Quantity INT, @Price MONEY, @TotalSales DECIMAL(18, 2);

DECLARE totalsales_cursor CURSOR STATIC FOR
SELECT ProductID, Quantity, Price FROM Products1;

OPEN totalsales_cursor;

FETCH NEXT FROM totalsales_cursor INTO @ProductID, @Quantity, @Price;

WHILE @@FETCH_STATUS = 0
BEGIN	
    SET @TotalSales = @Price * @Quantity;
    PRINT 'Product ID: ' + CAST(@ProductID AS VARCHAR) + ' Total Sales = ' + CAST(@TotalSales AS VARCHAR);

    FETCH NEXT FROM totalsales_cursor INTO @ProductID, @Quantity, @Price;
END;

CLOSE totalsales_cursor;
DEALLOCATE totalsales_cursor;







































