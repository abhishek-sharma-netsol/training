create database EmployeeDb

use EmployeeDb

create table Employees (
	EmployeeId int IDENTITY(1,1) Primary Key, 
	EmployeeName varchar(255) NOT NULL,
	EmployeeAge int Not NULL,
)


select * from Employees

Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name1', 20);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name2', 21);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name3', 23);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name4', 24);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name5', 25);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name6', 26);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name7', 27);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name8', 28);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name9', 29);
Insert Into Employees(EmployeeName, EmployeeAge) Values ('Name10', 30);


SELECT * INTO EmployeesTemp FROM Employees e

SELECT * FROM EmployeesTemp et
