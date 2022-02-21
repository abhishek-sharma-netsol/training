create database EmployeeDb

use EmployeeDb

create table Employees (
	EmployeeId int IDENTITY(1,1) Primary Key, 
	EmployeeName varchar(255) NOT NULL,
	EmployeeAge int Not NULL,
	DeptId int FOREIGN KEY REFERENCES EmployeeDept(DeptId)
)


select * from Employees

Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name1', 20, 1, 15000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name2', 21, 2, 16000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name3', 23, 1, 17000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name4', 24, 2, 18000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name5', 25, 1, 19000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name6', 26, 2, 20000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name7', 27, 1, 21000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name8', 28, 2, 22000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name9', 29, 1, 23000)
Insert Into Employees(EmployeeName, EmployeeAge, DeptId, Salary) Values ('Name10', 30, 2, 24000)


SELECT * INTO EmployeesTemp FROM Employees e

SELECT * FROM EmployeesTemp et

