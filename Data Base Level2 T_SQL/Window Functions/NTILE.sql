SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    NTILE(3) OVER (ORDER BY Grade DESC) AS Quartile
FROM 
    Students;
