--Task 1: Create a function to calculate the factorial of a number.
--Input: A positive integer.
--Output: Factorial of the number.
CREATE FUNCTION dbo.Fact(@Number INT)
RETURNS INT
AS 
BEGIN
    DECLARE @Result INT = 1;
    IF @Number < 0 RETURN NULL; -- Return NULL for invalid input
    WHILE @Number > 0
    BEGIN
        SET @Result = @Result * @Number;
        SET @Number = @Number - 1;
    END
    RETURN @Result;
END;

--Task 2: Create a function to check if a given year is a leap year.
--Input: A year.
--Output: 1 for leap year, 0 otherwise.
ALTER FUNCTION dbo.LeapYear(@Year INT)
RETURNS INT
AS 
BEGIN
    IF ((@Year % 4 = 0 AND @Year % 100 != 0) OR @Year % 400 = 0)
        RETURN 1; -- Leap year
    RETURN 0; -- Not a leap year
END;



--Task 3: Create a function to calculate the length of a given string.
--Input: A string.
--Output: Length of the string.
ALTER FUNCTION dbo.LenString(@Str NVARCHAR(MAX))
RETURNS INT
AS 
BEGIN
    RETURN LEN(@Str);
END;


--Task 4: Create a function to return the domain name from an email address.
--Input: Email address.
--Output: Domain name (e.g., gmail.com).
CREATE FUNCTION dbo.DomainName(@Email NVARCHAR(255))
RETURNS NVARCHAR(255)
AS 
BEGIN
    IF CHARINDEX('@', @Email) > 0
        RETURN SUBSTRING(@Email, CHARINDEX('@', @Email) + 1, LEN(@Email));
    RETURN NULL; -- Invalid email
END;


--Task 5: Create a function to calculate the difference in days between two dates.
--Input: Two dates.
--Output: Number of days between them.
CREATE FUNCTION dbo.DaysBetween(@StartDate DATE, @EndDate DATE)
RETURNS INT
AS 
BEGIN
    RETURN DATEDIFF(DAY, @StartDate, @EndDate);
END;


--Task 6: Create a function to capitalize the first letter of each word in a string.
--Input: A sentence.
--Output: Sentence with each word capitalized.
CREATE FUNCTION dbo.CapitalizeWords(@Input NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS 
BEGIN
    DECLARE @Result NVARCHAR(MAX) = LOWER(@Input);
    RETURN UPPER(LEFT(@Result, 1)) + 
           STUFF(@Result, 2, LEN(@Result), LOWER(SUBSTRING(@Result, 2, LEN(@Result))));
END;


--Task 7: Create a function to calculate the age of a person given their birthdate.
--Input: Birthdate.
--Output: Age in years.

CREATE FUNCTION dbo.CalculateAge(@BirthDate DATE)
RETURNS INT
AS 
BEGIN
    RETURN DATEDIFF(YEAR, @BirthDate, GETDATE()) - 
           CASE WHEN MONTH(@BirthDate) > MONTH(GETDATE()) OR 
                     (MONTH(@BirthDate) = MONTH(GETDATE()) AND DAY(@BirthDate) > DAY(GETDATE()))
                THEN 1 ELSE 0 END;
END;

--Task 8: Create a function to format a phone number.
--Input: A 10-digit number (e.g., 1234567890).
--Output: Formatted number (e.g., (123) 456-7890).
CREATE FUNCTION dbo.FormatPhoneNumber(@PhoneNumber BIGINT)
RETURNS NVARCHAR(20)
AS 
BEGIN
    RETURN '(' + SUBSTRING(CAST(@PhoneNumber AS NVARCHAR), 1, 3) + ') ' +
           SUBSTRING(CAST(@PhoneNumber AS NVARCHAR), 4, 3) + '-' +
           SUBSTRING(CAST(@PhoneNumber AS NVARCHAR), 7, 4);
END;

SELECT dbo.FormatPhoneNumber(93921970) As TelNum;

--Task 9: Create a function to return the initials of a full name.
--Input: Full name (e.g., John Doe).
--Output: Initials (e.g., J.D.).
CREATE FUNCTION dbo.Initials(@FullName NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS 
BEGIN
    RETURN LEFT(@FullName, 1) + '.' + 
           SUBSTRING(@FullName, CHARINDEX(' ', @FullName) + 1, 1) + '.';
END;

SELECT dbo.Initials('Oussama Abdelli') AS Initialname ;

--Task 10: Create a function to calculate the BMI (Body Mass Index).
--Input: Weight in kg and height in meters.
--Output: BMI value.
ALTER FUNCTION dbo.BMI(@Weight FLOAT, @Height FLOAT)
RETURNS FLOAT
AS 
BEGIN
    IF @Height = 0 RETURN NULL; -- Avoid division by zero
    RETURN @Weight / (@Height * @Height);
END;
