using Microsoft.EntityFrameworkCore;

namespace LMS.Data.Entities
{
    public class LMSDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyLMSDatabase");
        }
    }
}
