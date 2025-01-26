restore database Employyes_Managers 
from disk ='C:\Databases\EmployeesDB.bak';

Use Employyes_Managers ;
GO 
alter AUTHORIZATION  ON DATABASE ::Employyes_Managers TO [sa]
GO

select * from Employees;

--Get all employees that have manager along with Manager's name.
SELECT        Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM            Employees INNER JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
--Get all employees that have manager or does not have manager along with Manager's name, incase no manager name show null
SELECT        Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM            Employees Left JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
--Get all employees that have manager or does not have manager along with Manager's name, incase no manager name the same employee name as manager to himself
SELECT        Employees.Name, Employees.ManagerID, Employees.Salary,  
  CASE
    WHEN Managers.Name is Null  THEN Employees.Name
    ELSE Managers.Name
END as ManagerName
FROM            Employees Left JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID

--Get All Employees managed by 'Mohammed'
SELECT        Employees.Name, Employees.ManagerID, Employees.Salary, Managers.Name AS ManagerName
FROM            Employees INNER JOIN
                         Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
where Managers.Name='Mohammed'


