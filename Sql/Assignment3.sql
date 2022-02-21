
-----------------------------
SELECT DeptId from Employees 
UNION 
SELECT DeptId from EmployeeDept ed   

SELECT DeptId from Employees 
UNION ALL
SELECT DeptId from EmployeeDept ed

-- Views

Create View SelectView As 
SELECT E.EmployeeName,E.EmployeeAge,E.Salary,D.Experience FROM Employees AS E INNER JOIN EmployeeDept AS D ON E.DeptID=D.DeptID

Select * from SelectView 

DECLARE @PageNumber AS INT
            DECLARE @RowsOfPage AS INT
        DECLARE @MaxTablePage  AS FLOAT
        SET @PageNumber=1
        SET @RowsOfPage=3
        SELECT @MaxTablePage = COUNT(*) FROM Employees
        SET @MaxTablePage = CEILING(@MaxTablePage/@RowsOfPage)
        WHILE @MaxTablePage >= @PageNumber
        BEGIN
         SELECT EmployeeName, EmployeeAge, DeptId, Salary from Employees e order by Salary
        OFFSET (@PageNumber-1)*@RowsOfPage ROWS
        FETCH NEXT @RowsOfPage ROWS ONLY
        SET @PageNumber = @PageNumber + 1
        END

        
-- Join
SELECT E1.EmployeeID,E1.EmployeeName FROM Employees AS E1 ,Employees E2 WHERE E1.Salary<>E2.Salary AND E1.DeptID=E2.DeptID ORDER BY E1.EmployeeID DESC;
SELECT E.EmployeeID ,E.EmployeeName, D.DeptId ,D.Name FROM Employees AS E RIGHT JOIN EmployeeDept AS D ON E.DeptID=D.DeptID;
SELECT E.EmployeeName,E.EmployeeAge,E.Salary,D.Experience FROM Employees AS E INNER JOIN EmployeeDept AS D ON E.DeptID=D.DeptID
SELECT E.EmployeeID ,E.EmployeeName ,D.DeptId  FROM Employees AS E INNER JOIN EmployeeDept AS D ON E.DeptID=D.DeptID;


-- Procedure
create PROCEDURE usp_SelectAllEmployeeDept
As
SELECT * from EmployeeDept
Go;

create PROCEDURE usp_SelectAllEmployees
As 
Select * from Employees
Go;

EXEC usp_SelectAllEmployees
EXEc usp_SelectAllEmployeeDept


SELECT EmployeeId, EmployeeName
FROM Employees
ORDER BY EmployeeId
OFFSET 3 ROWS;

Declare @tempEmployees AS INT

SELECT COUNT(*) FROM @tempCoach  
                     
SELECT * FROM                            
  (                          
   SELECT ROW_NUMBER() OVER (ORDER BY CoachName)-1 AS Row,* FROM @tempCoach                        
  )Coach                          
WHERE (Row between (@istartRowIndex) AND @istartRowIndex + (@imaximumRows -1))    
@istartRowIndex INT,                                          
@imaximumRows INT  
CREATE PROCEDURE [uspGetCoaches]                       
(                          
@iUniversityID BIGINT,                          
@iSportID BIGINT,                          
@sCoachName VARCHAR(100),                        
@istartRowIndex INT,                                          
@imaximumRows INT                          
)  
