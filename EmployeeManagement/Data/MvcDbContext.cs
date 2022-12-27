using EmployeeManagement.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class MvcDbContext : DbContext
    {
        //Constructor
        public MvcDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
