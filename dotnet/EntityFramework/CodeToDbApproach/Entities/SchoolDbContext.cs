using Microsoft.EntityFrameworkCore;

namespace CodeToDbApproach.Entities
{
    public class SchoolDbContext : DbContext {
      public DbSet<Teacher> Teachers { get; set; }
      public DbSet<Student> Students { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
        optionsBuilder.UseSqlServer("Server=localhost;Database=SchoolDbCodeFirst;Trusted_Connection=False; User Id=sa; Password=*@1abhimssql@*;");
      }
    }
}
