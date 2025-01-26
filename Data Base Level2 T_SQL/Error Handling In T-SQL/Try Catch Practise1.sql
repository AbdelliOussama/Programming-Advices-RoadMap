
--TASK 1
--DECLARE @Number INT;
--DECLARE @Result INT ;

--BEGIN TRY
--	SET @Number = 50;
--	SET @Result = @Number / 0;
--	PRINT 'Result  = '+ CAST(@Result AS VARCHAR);
--END TRY
--BEGIN CATCH
--	PRINT'Error Occured : '+ERROR_MESSAGE();
--END CATCH

------TASK 2

------ Create the `OrderTable` if it doesn't exist
--CREATE TABLE OrderTable
--(
--    OrderID INT NOT NULL PRIMARY KEY,
--    OrderName VARCHAR(30) NOT NULL,
--    Amount MONEY NOT NULL
--);

---- Create the `ErrorLog` table for storing error details
--CREATE TABLE ErrorLog
--(
--    ErrorMessage NVARCHAR(200),
--    ErrorSeverity INT,
--    ErrorState INT
--);

--BEGIN TRY
--    -- Insert with an invalid value to trigger an error
--    INSERT INTO OrderTable VALUES (1, 'PIZZA', -30);
--END TRY
--BEGIN CATCH
--    -- Log the error details in the `ErrorLog` table
--    INSERT INTO ErrorLog 
--    VALUES (
--        ERROR_MESSAGE(),
--        ERROR_SEVERITY(),
--        ERROR_STATE()
--    );
--END CATCH;

---- Display the records in the tables
--SELECT * FROM OrderTable;
--SELECT * FROM ErrorLog;
