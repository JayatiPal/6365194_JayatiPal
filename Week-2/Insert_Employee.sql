/*CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;


EXEC sp_InsertEmployee 
    @FirstName = 'Robert',
    @LastName = 'Brown',
    @DepartmentID = 3,  
    @Salary = 6500.00,
    @JoinDate = '2023-05-10';
    
    */
SELECT * FROM Employees;
