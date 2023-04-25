using Emp_register1web.Models;
using Microsoft.EntityFrameworkCore;

namespace Emp_register1web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<EmpRegister> EmpRegister { get; set; } 
    }
}
