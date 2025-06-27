CREATE PROCEDURE GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID, 
        FirstName, 
        LastName, 
        Salary, 
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;


EXEC GetEmployeesByDepartment @DepartmentID = 1;
