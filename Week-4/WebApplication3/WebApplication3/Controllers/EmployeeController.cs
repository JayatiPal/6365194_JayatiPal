using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication3.Models;


[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
[ServiceFilter(typeof(CustomExceptionFilter))]
[ProducesResponseType(typeof(Employee), 200)]
[ProducesResponseType(400)]


public class EmployeeController : ControllerBase
{
    private static List<Employee> _employees;

    static EmployeeController()
    {
        _employees = GetStandardEmployeeList();
    }

    // GET: /Employee
    [HttpGet]
    [ProducesResponseType(typeof(List<Employee>), 200)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(_employees);
    }

    // GET: /Employee/standrad
    [HttpGet("standrad")]
    public ActionResult<Employee> GetStandrad()
    {
        return Ok(_employees.FirstOrDefault());
    }

    [HttpGet("throw")]
    [ProducesResponseType(500)]
    public IActionResult GetWithError()
    {
        throw new Exception("Test exception");
    }


    // POST: /Employee
    [HttpPost]
    public ActionResult<Employee> Post(Employee emp)
    {
        _employees.Add(emp);
        return CreatedAtAction(nameof(Get), new { id = emp.Id }, emp);
    }

    [HttpPut("{id}")]
    public ActionResult<Employee> Put(int id, [FromBody] Employee emp)
    {
        if (id <= 0)
            return BadRequest("Invalid employee id");

        var existing = _employees.FirstOrDefault(e => e.Id == id);
        if (existing == null)
            return BadRequest("Invalid employee id");

        // Update fields
        existing.Name = emp.Name;
        existing.Salary = emp.Salary;
        existing.Permanent = emp.Permanent;
        existing.Department = emp.Department;
        existing.Skills = emp.Skills;
        existing.DateOfBirth = emp.DateOfBirth;

        return Ok(existing);

    }


    private static List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John Doe",
                Salary = 50000,
                Permanent = true,
                Department = new Department { Id = 1, Name = "HR" },
                Skills = new List<Skills> { new Skills { Id = 1, Name = "C#" } },
                DateOfBirth = new DateTime(1990, 1, 1)
            },
            new Employee
        {
            Id = 2,
            Name = "Jane Smith",
            Salary = 60000,
            Permanent = false,
            Department = new Department { Id = 2, Name = "IT" },
            Skills = new List<Skills>
            {
                new Skills { Id = 3, Name = "C#" },
                new Skills { Id = 4, Name = "SQL" }
            },
            DateOfBirth = new DateTime(1985, 8, 15)
        }

        };
    }
}
