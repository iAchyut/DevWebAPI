using DevWebAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace DevWebAPI.Data
{
    public class EmployeeDBContext: DbContext
    {
       
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
