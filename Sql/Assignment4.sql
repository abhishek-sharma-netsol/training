CREATE TABLE #TempTable
(
 TableId INT IDENTITY(1,1) PRIMARY KEY,
 Name VARCHAR(50) NOT NULL,
)

INSERT INTO #TempTable
SELECT EmployeeName 
FROM dbo.Employees

select * from #TempTable

DECLARE @TableVariable=TableVar
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name VARCHAR(50) NOT NULL 
)

INSERT INTO TableVariable 
SELECT EmployeeName 
FROM dbo.Employees

-- Table Type

CREATE TYPE TempType AS TABLE(
  TempId  INT,
  TempFirstName VARCHAR(100),
  TempLastName VARCHAR (100)
)

CREATE TABLE Temperary (
        Id  INT PRIMARY KEY,
        FirstName VARCHAR(50),
        LastName VARCHAR(50)      
)

CREATE PROCEDURE UspInsertTemp @TempType TempType READONLY
AS
INSERT INTO Temperary
SELECT * FROM TempType
DECLARE @VarAbcType AS TempType
INSERT INTO @VarAbcType
VALUES ( 1, 'FirstName1', 'LastName1'
       )
       INSERT INTO @VarAbcType
VALUES ( 2, 'FirstName2', 'LastName2'
       )

EXECUTE UseInsertTemp VarAbcType
SELECT * FROM Temperary 


-- Functions
create procedure GetData @list as varchar(100), @sep varchar(1)=","
As
Begin
	SELECT * from STRING_SPLIT(@list, @sep)
END

exec GetData '1,2,3,4,5'


alter table EmployeeDept 
DROP Column Pos

alter table EmployeeDept
Add Pos varchar(255)

select * from EmployeeDept ed

Update EmployeeDept 
SET Pos='1'
WHERE DeptId=1

Update EmployeeDept 
SET Pos='2'
WHERE DeptId=2

CREATE FUNCTION DeptInfo()
RETURNS table
as
RETURN(SELECT
		VALUE Pos
	FROM
		EmployeeDept
		CROSS APPLY STRING_SPLIT(Pos, ' '))
----------------------PROCEDURE FOR FUNCTION-------------------
CREATE PROCEDURE UspGetDetail
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM DeptInfo()
END
GO
EXEC UspGetDetail
