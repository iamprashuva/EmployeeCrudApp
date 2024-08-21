using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudApp.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }
         public DbSet<Employees> Employees { get; set; }
    }
}
