using Microsoft.EntityFrameworkCore;

namespace BloApiDemo.DataAccessLayer
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =LAPTOP-AR4409OM; database=NetCoreProjeBlogApi;" +
                "Integrated Security = true;");
        }
        public DbSet<Employee> employees { get; set; }
    }
}
