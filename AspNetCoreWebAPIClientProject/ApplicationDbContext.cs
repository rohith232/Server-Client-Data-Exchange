using AspNetCoreWebAPIClientProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace YourNamespace.Models
{


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // Other DbSet properties for other entities if any

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your model here
        }
    }
}
