using CQRS.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.API.Persistance
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options): base(options) { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(c =>
            {
                c.HasKey(x => x.Id);
                c.Property(x => x.FullName).IsRequired(); 
                c.Property(x => x.Email).IsRequired();
                c.Property(x => x.PhoneNumber).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
