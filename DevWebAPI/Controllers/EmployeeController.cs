using DevWebAPI.Data;
using DevWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DevWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDBContext dbContext;

        public EmployeeController(EmployeeDBContext DbContext)
        {
            this.dbContext = DbContext;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
           var AllEmp= dbContext.Employees.ToList();
            // This is a placeholder for the actual implementation
            return Ok(AllEmp);
        }

        [HttpPost]

        public IActionResult AddEmployee(AddEmployee employee)
        {
            var newEmp = new Employee()
            {
                email = employee.email,
                Fistname = employee.Fistname,
                Lastname = employee.Lastname,
                Phone = employee.Phone
            };

            dbContext.Employees.Add(newEmp);
            dbContext.SaveChanges();

            return Ok(newEmp);

        }
    }
}
