using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace MVCDemoNetCore.Models
{
    public class SchoolContext :DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; Initial Catalog=SchoolDB; Integrated Security=True;trustservercertificate=True");
            //optionsBuilder.UseSqlServer(" Server = tcp:sqldbexample.database.windows.net,1433; Initial Catalog = aalmeyda; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

           

        }

    }
}
