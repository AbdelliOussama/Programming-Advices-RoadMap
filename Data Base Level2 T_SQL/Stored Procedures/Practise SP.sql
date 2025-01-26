

--TASK2
CREATE PROCEDURE sp_UpdateProductStock
	@ProductID INT,
	@NewStock INT
AS 
BEGIN
	BEGIN TRY
		IF @NewStock >= 0
			BEGIN
				UPDATE Products1 
				SET
				Stock = @NewStock 
				WHERE ProductID = @ProductID;
			END
		ELSE
			THROW 50393,'Stock Cant Be a Negative Value',5
	END TRY
	BEGIN CATCH
	PRINT ERROR_MESSAGE()
	END CATCH
END

EXEC sp_UpdateProductStock
	@ProductID = 1,
	@NewStock = -6


--Task 3
CREATE PROCEDURE SP_GetOrdersByDate
	@StartDate Date,
	@EndDate Date

AS
BEGIN 
	BEGIN TRY
		IF EXISTS (SELECT * FROM Orders  WHERE OrderDate BETWEEN @StartDate AND @EndDate)
			BEGIN 
				SELECT * FROM Orders  WHERE OrderDate BETWEEN @StartDate AND @EndDate
			END
		ELSE
			THROW 53044,'No Order Found',5
	END TRY
	BEGIN CATCH
		PRINT 'ERROR : '+ERROR_MESSAGE()+ 'ERRROR NUMBER = '+ERROR_NUMBER();
	END CATCH
END

EXEC SP_GetOrdersByDate
	@StartDate = '2024-11-05',
	@EndDate = '2024-11-18'



--Task4
CREATE PROCEDURE SP_CalculteSales
	@CategoryID INT, 
	@TotalSales INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF EXISTS(SELECT Category FROM Products1 WHERE Category= @CategoryID)
			BEGIN
				SELECT @TotalSales = SUM(Stock) FROM Products1 WHERE Category = @CategoryID;
			END
		ELSE
			THROW 57654,'No Product With Category  = CAST(@CategoryID AS VARCHAR) ',6
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE();
	END CATCH
END

--TASK 7
SELECT * FROM Orders;
SELECT * from Customers

CREATE PROCEDURE SP_GetCustomerOrderDetails
	@CustomerID INT 
AS 
BEGIN
	BEGIN TRY
		IF EXISTS(SELECT CustomerID FROM Customers WHERE CustomerID = @CustomerID)
			BEGIN
				SELECT Customers.CustomerName,Customers.CustomerEmail,Orders.OrderDate,Orders.Status,Orders.DeliveryDate FROM 
				Customers INNER JOIN Orders ON Customers.CustomerName = Orders.CustomerName 
				WHERE Customers.CustomerID = @CustomerID;
			END
			ELSE
				 THROW 68664,'No Customer Found With Given CustomerID',6;
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
	END CATCH
END
