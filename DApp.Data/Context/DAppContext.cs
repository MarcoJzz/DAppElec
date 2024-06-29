using DApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DApp.Data.Context
{
        public class DAppContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseInMemoryDatabase("DAppDb");
            }
            public DbSet<Category> Categories { get; set; }
                
        }
    
}
