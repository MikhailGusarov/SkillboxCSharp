using Examplе_2541.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examplе_2541.ContextFolder
{
    public class DataContext : DbContext
    {
        public DbSet<Car> Cars{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Проект урока находится в архиве Examplе_2541Local.zip
            текущий проект - результат урока 5
            optionsBuilder.UseSqlServer(
            //@"Server=(localdb)\MSSQLLocalDB;  DataBase=_EntityCoreExamplе2541;    Trusted_Connection=True;"
            @"Server=tcp:databasegroup2541.database.windows.net,1433;Initial Catalog=Example2541;Persist Security Info=False;User ID=admin2541;Password=YOURPASSWORD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"                
            );
            
        }
    }
}
