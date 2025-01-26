
CREATE TABLE Employees
(EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
Name nvarchar(50) not null,
Department nvarchar(50) not null,
Salary money not null
);
Insert INTO Employees
Values('Emily','IT',4500)

select * from Employees;

DECLARE @EmployeeID INT
DECLARE @EmployeeName VARCHAR(50);
DECLARE @Salary MONEY ;
DECLARE @Bounus MONEY;

SET @EmployeeID = 1;
SELECT @EmployeeName = Name ,@Salary=Salary FROM Employees 
where EmployeeID =@EmployeeID;

IF @Salary >5000
	BEGIN 
		PRINT 'The BONUS is 10% ' 
	END
ELSE
	IF @Salary>4000 AND @Salary<4999
		BEGIN
			PRINT 'The BONUS is 8% '
		END
	ELSE
		BEGIN	
			PRINT 'The BONUS is 5% '
		END
PRINT 'EMPLOYEE NAME : '+CAST(@EmployeeName AS varchar)
PRINT 'EMPLOYEE ID : ' +CAST(@EmployeeID AS varchar)
PRINT 'EMPLOYEE Salary : '+CAST(@Salary AS varchar)



SELECT * FROM Employees;

DECLARE @EmployeeName VARCHAR(30);
DECLARE @Department VARCHAR(30);

SELECT @EmployeeName = Name ,@Department = Department FROM Employees 
WHERE Salary = 5000;

IF @Department = 'IT' 
	BEGIN 
		PRINT 'EMPLOYEE :'+@EmployeeName +' ' +'WORKS IN IT  '+@Department ;
	END
ELSE
	BEGIN
		PRINT 'EMPLOYEE :'+@EmployeeName +' ' +' WORKS IN '+@Department ;
	END


DECLARE @Age INT;
DECLARE @Category VARCHAR(30);

SET @Age = 18;
IF @Category>=18 
	BEGIN 
		SET @Category ='Senior';
	END
ELSE
	BEGIN
		SET @Category = 'Junior';
	END
PRINT 'AGE : '+CAST(@Age AS VARCHAR);
PRINT 'CATEGORY : '+@Category;

DECLARE @CurrentDate DATE = GETDATE();
DECLARE @EventDay DATE = DATEFROMPARTS(2024,12,1);

IF @EventDay > @CurrentDate 
	BEGIN 
		PRINT 'The event is upcoming';
	END
ELSE
	IF @CurrentDate =@EventDay
		BEGIN
			PRINT 'The event is today!';
		END
	ELSE
		BEGIN 
			PRINT 'The event has passed.';
		END
	

DECLARE @JoiningDate DATE = '1980-06-15';
DECLARE @RetirementAge INT = 60;
DECLARE @CurrentAge INT;
DECLARE @YearsToRetirement INT;

 Calculate current age based on joining date assuming 25 years at joining
SET @CurrentAge = 25 + DATEDIFF(YEAR, @JoiningDate, GETDATE());

 Calculate years left until retirement
SET @YearsToRetirement = @RetirementAge - @CurrentAge;

 Check retirement eligibility
IF @YearsToRetirement <= 0
    BEGIN
        PRINT 'Employee is eligible for retirement.';
    END
ELSE
    BEGIN
        PRINT 'Employee is NOT eligible for retirement. It is left ' 
              + CAST(@YearsToRetirement AS VARCHAR) + ' years.';
    END
