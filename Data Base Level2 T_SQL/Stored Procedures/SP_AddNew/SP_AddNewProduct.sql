CREATE TABLE Products1 (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(50),
    Price MONEY
);

CREATE PROCEDURE AddProduct
    @ProductName VARCHAR(50),
    @Price MONEY,
    @Message VARCHAR(100) OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Products1 WHERE ProductName = @ProductName)
    BEGIN
        SET @Message = 'Product already exists!';
        RETURN;
    END

    INSERT INTO Products1 (ProductName, Price)
    VALUES (@ProductName, @Price);

    SET @Message = 'Product added successfully!';
END;



DECLARE @ResultMessage VARCHAR(100);
EXEC AddProduct 'Laptop', 1500.00, @ResultMessage OUTPUT;
PRINT @ResultMessage;
