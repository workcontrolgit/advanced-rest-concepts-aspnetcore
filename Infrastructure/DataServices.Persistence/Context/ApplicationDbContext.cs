using DataServices.Core.Domain.Entities;
using DataServices.Persistence.Mock;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Core.Domain.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FakeData.Init(1000);

            modelBuilder.Entity<Employee>().HasData(FakeData.Employees);
            modelBuilder.Entity<Assignment>().HasData(FakeData.Assignments);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
	}
}
