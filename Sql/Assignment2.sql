use EmployeeDb

create table EmployeeDept(
	DeptId int IDENTITY (1,1) Primary Key,
	Name varchar(255) NOT NULL,
	Experience int NOT NULL
)

select * from EmployeeDept ed

INSERT INTO EmployeeDept Values('Name1', '4')
INSERT INTO EmployeeDept Values('Name2', '5')

Alter Table Employees Add Salary Decimal(10,2)

Select top 5 * from Employees Order by 1 desc

SELECT top 5 EmployeeName, EmployeeAge From Employees order by EmployeeName 

select DISTINCT  DeptId, EmployeeName from Employees e  WHERE Salary > 18000

SELECT * FROM Employees  WHERE EmployeeName LIKE 'A%'

SELECT * FROM Employees  WHERE DeptID=1 AND SALARY >16000;

​
SELECT COUNT(Salary) FROM Employees e ;

SELECT MAX(Salary) [Maximum Salary] from Employees e 
SELECT MIN(Salary) [Minimum Salary] from Employees e2;

