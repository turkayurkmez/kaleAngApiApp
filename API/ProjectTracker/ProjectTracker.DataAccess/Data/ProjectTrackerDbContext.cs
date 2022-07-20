using Microsoft.EntityFrameworkCore;
using ProjectTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DataAccess.Data
{
    public class ProjectTrackerDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public ProjectTrackerDbContext(DbContextOptions<ProjectTrackerDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categories = new Category[]
                {
                    new Category { Id=1, Name = "Finans" },
                    new Category { Id=2, Name = "İnsan Kaynakları" }

                };

            var tasks = new ProjectTask[]
            {
                new ProjectTask{ Id=1, Name="Veritabanı işlemleri", Description="Db oluşturulacak", ProjectId=1, ExpectedDate=DateTime.Now.AddDays(7) },
                new ProjectTask{ Id=2, Name="API Yazılacak", Description=".NET Core ile API altyapısı...", ProjectId=1, ExpectedDate=DateTime.Now.AddDays(15),  },
                new ProjectTask{ Id=3, Name="Angular Altyapısı", Description="Angular öğrenilecek", ProjectId=2, ExpectedDate=DateTime.Now.AddDays(7) },
                new ProjectTask{ Id=4, Name="Güvenlik mekanizması", Description="....", ProjectId=2, ExpectedDate=DateTime.Now.AddDays(3),  }



            };

            var projects = new Project[]
            {
                new Project { Id=1, CategoryId = 1, Name="Ödeme Sistemleri", Description="Kale grubu ve bankalar arası ödeme işlemleri", StartedDate=DateTime.Now },
                new Project { Id=2, CategoryId = 2, Name="HR Yetki Modülü", Description="Kale grubu İK personeli yetkilendirme uygulaması", StartedDate=DateTime.Now },
            };


            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Project>().HasData(projects);
            modelBuilder.Entity<ProjectTask>().HasData(tasks);






            base.OnModelCreating(modelBuilder);
        }
    }
}
