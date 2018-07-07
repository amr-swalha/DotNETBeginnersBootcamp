using Microsoft.EntityFrameworkCore;

namespace Section22.ASPNETCoreAdvanced.Models
{
    public class UniContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NETBeginnerBootCamp;Data Source=.");
        }

        public DbSet<Student> Students { get; set; }
    }
}
