
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;


namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Jane Smith", Department = "IT", Salary = 60000 },
            new Employee { Id = 3, Name = "Mike Johnson", Department = "Finance", Salary = 55000 }

        };
    

            // PUT: api/employee/2
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            // Check if ID is invalid
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Find employee by ID
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            // If employee doesn't exist
            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update employee data
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Salary = updatedEmployee.Salary;

            // Return updated employee
            return Ok(existingEmployee);
        }
    }
}



