using DApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DApp.Data.Context
{
        public class DAppContext : DbContext
        {
        public DAppContext(DbContextOptions<DAppContext> options) : base(options)
        {

        }
        public DAppContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseInMemoryDatabase("School");
            }
            public DbSet<Department> Departments { set; get; }

            public DbSet<Course> Courses { set; get; }

    }
    
}
