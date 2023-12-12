using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Persistence
{
    public class EmployeeManagementDBContext : DbContext
    {
        public EmployeeManagementDBContext(DbContextOptions<EmployeeManagementDBContext> options) : base(options) { }

        public DbSet<Employees> Employees { get; init; } = null!;
        public DbSet<Expenses> Expenses { get; init; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeManagementDBContext).Assembly);

            modelBuilder.Entity<Employees>()
                .HasKey(e => e.EmployeeID);

            modelBuilder.Entity<Expenses>()
                .HasKey(e => e.EmployeeID);

            modelBuilder.Entity<Expenses>()
                .HasOne(e => e.Employees)
                .WithOne(e => e.Expenses)
                .HasForeignKey<Expenses>(e => e.EmployeeID)
                .IsRequired(false);
        }
    }
}
