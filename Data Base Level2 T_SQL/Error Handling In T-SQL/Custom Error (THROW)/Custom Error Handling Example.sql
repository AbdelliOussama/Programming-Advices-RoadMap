---Task 1

DECLARE @Number INT ;
BEGIN TRY
	SET @Number =-1;
	IF @Number <0 OR @Number>100
		 THROW 50100, 'Invalid Number Inter Another Number',2;
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE() AS ErrorMsg
	--SELECT ERROR_NUMBER()  AS ErrorNum;
END CATCH

--I didnt Studied Procedure Yet 
	
--- TASK 2
CREATE TABLE Products2
(ProductID INT IDENTITY(1,1) PRIMARY KEY,
ProductName Varchar(30) NOT NULL
);

DECLARE @ProductName VARCHAR(30);
BEGIN TRY
	SET @ProductName =NULL;
	INSERT INTO Products2 (ProductName)
	VALUES (@ProductName);
	IF(@ProductName IS NULL)
		THROW 50001 ,'Can Not Insert Null Value To Product Name',3 ;
END TRY 
BEGIN CATCH 
	SELECT ERROR_MESSAGE() AS ErrorMsg,ERROR_NUMBER() AS ErrorNum ;
END CATCH
		

--Task 3
DECLARE @Number1 INT = 10;
DECLARE @Number2 INT = 0;
DECLARE @Result DECIMAL;

BEGIN TRY
    IF @Number2 = 0
        THROW 60000, 'Division by Zero is Forbidden', 5;
    SET @Result = @Number1 / @Number2;
END TRY
BEGIN CATCH
    SELECT ERROR_MESSAGE() AS ErrorMsg, ERROR_NUMBER() AS ErrorNum;
END CATCH;

--TASK 4
CREATE TABLE Users 
(UserID INT IDENTITY(1,1) PRIMARY KEY,
UserName VARCHAR(30 )
);
INSERT INTO Users VALUES ('Oussama')
DECLARE @UserName VARCHAR(30);
BEGIN TRY 
	SET @UserName = 'Oussama';
	IF EXISTS (SELECT * FROM Users WHERE UserName =@UserName )
		THROW 60004,'This user Name Is Already Exists',6;
	Insert INTO Users Values (@UserName);
END TRY
BEGIN CATCH 
	SELECT ERROR_MESSAGE() AS ErrorMsg,ERROR_NUMBER() AS ErrorNum ;
END CATCH

