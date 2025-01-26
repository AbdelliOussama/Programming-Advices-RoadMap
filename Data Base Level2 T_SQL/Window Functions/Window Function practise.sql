
--Task 1
SELECT * FROM 
(SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    ROW_NUMBER() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS RowNum
FROM 
    Students
)AS Stu
WHERE RowNum<=3
	--Task 2

	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS Rank
FROM 
    Students;

--Task 3
	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    RANK() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS Rank,
    DENSE_RANK() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS DenseRank
FROM 
    Students;


	--Task 4

	SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    NTILE(4) OVER (ORDER BY Grade DESC) AS Quartile
FROM 
    Students;


	--Task 5

	WITH RankedStudents AS (
    SELECT 
        StudentID, 
        Name, 
        Subject, 
        Grade,
        ROW_NUMBER() OVER (PARTITION BY Subject ORDER BY Grade DESC) AS RowNum
    FROM 
        Students
)
SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade
FROM 
    RankedStudents
WHERE 
    RowNum = 1;


	--Task 6

	WITH RankedRecords AS (
    SELECT 
        StudentID, 
        Name, 
        Subject, 
        Grade,
        ROW_NUMBER() OVER (ORDER BY Grade DESC) AS RowNum
    FROM 
        Students
)
SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade
FROM 
    RankedRecords
WHERE 
    RowNum BETWEEN 11 AND 20;

	--Task 7

	WITH DuplicateRecords AS (
    SELECT 
        *, 
        ROW_NUMBER() OVER (PARTITION BY Name, Subject, Grade ORDER BY StudentID) AS RowNum
    FROM 
        Students
)
DELETE FROM DuplicateRecords
WHERE RowNum > 1;


--Task 8
SELECT * FROM 
(SELECT 
Name,Department,Salary,RANK() OVER (PARTITION BY Department ORDER BY Salary DESC) As SalaryRank
FROM Employees2
)AS Emp 
WHERE SalaryRank <6


--Task 9 
SELECT 
    PlayerID, 
    PlayerName, 
    Score,
    ROW_NUMBER() OVER (ORDER BY Score DESC) AS RowNumber,
    RANK() OVER (ORDER BY Score DESC) AS Rank,
    DENSE_RANK() OVER (ORDER BY Score DESC) AS DenseRank
FROM 
    Players;



----------------------------------------------------------------------------------------------------------------------------------
--Task 1
SELECT StudentID, Name, Subject, Grade  FROM
(
SELECT StudentID, Name, Subject, Grade,ROW_NUMBER() OVER(PARTITION BY Subject Order By Grade DESC) AS RankGrade FROM Students
)AS Stu
WHERE RankGrade <=3


--TASK 2
SELECT StudentID, Name, Subject, Grade  FROM
(
SELECT StudentID, Name, Subject, Grade,RANK() OVER(PARTITION BY Subject Order By StudentID DESC) AS RankGrade FROM Students
)AS Stu
WHERE RankGrade <=3

--Task 3 
SELECT EmployeeID,Name,Salary,DENSE_RANK()OVER(ORDER BY Salary DESC) AS SalaryRank  FROM Employees 

--Task 4
SELECT EmployeeID,Name,Salary,NTILE(4)OVER(ORDER BY Salary DESC) AS Quartile  FROM Employees 
--Task 5
SELECT EmployeeID,Name,Salary,SUM(Salary)OVER(ORDER BY Salary DESC) SumSalary  FROM Employees 

--Task 6
SELECT * ,SUM(Price) OVER(PARTITION BY Category ) As TotalPrice FROM Products
--TASK 7
SELECT EmployeeID,Name,Salary,Department,AVG(Salary)OVER(PARTITION BY Department) AS AverageSalary  FROM Employees 
--TASK 8
SELECT EmployeeID,Name,Salary,Department,LAG(Salary,1)OVER(Order By Salary DESC) AS PreviousSalary FROM Employees 
--Task 9
SELECT StudentID, Name, Subject, Grade,LEAD(Grade,1) OVER(PARTITION BY Subject Order By Grade DESC) AS NextGrade FROM Students;
--Task 10
SELECT 
    SalesPersonID, 
    SalesAmount, 
    RANK() OVER (ORDER BY SalesAmount DESC) AS Rank,
    PERCENT_RANK() OVER (ORDER BY SalesAmount DESC) AS PercentRank
FROM 
    Sales;

