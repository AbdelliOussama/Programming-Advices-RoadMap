--Task 1
-- Extract the domain name from the Email column
SELECT Email,
       SUBSTRING(Email, CHARINDEX('@', Email) + 1, LEN(Email)) AS DomainName
FROM Employees;


--Task 2
Declare @Iteration INT = 1;
DECLARE @Date DATE = GETDATE();
WHILE @Iteration<=30
	BEGIN 
		PRINT CONVERT(VARCHAR ,@Date,103);
		SET @Date = DATEADD(DAY,1,@Date);
		SET @Iteration = @Iteration+1;
	END

		
--Task 3
SELECT CONVERT(VARCHAR ,GETDATE(),103) AS CurrentDate ;

--Task 4 
SELECT Name FROM Employees WHERE LEN(NAME)>10;

--TASK 5

SELECT Age =DATEDIFF(YEAR,GETDATE(),BirthDate) FROM Employees;

--TASK 6
SELECT NAME from Employees WHERE SUBSTRING(NAME,1,2) = 'Jo';

--TASK 7 
SELECT * FROM Products WHERE ExpireeDate < GETDATE();

--Task 10
SELECT DATENAME(WEEKDAY, '2024-12-25') AS DAYNAMEE;
