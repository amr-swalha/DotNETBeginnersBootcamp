using Microsoft.EntityFrameworkCore;

namespace Section21.EntityFrameWork
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NETBeginnerBootCamp;Data Source=.");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Gradeses { get; set; }
    }
}
