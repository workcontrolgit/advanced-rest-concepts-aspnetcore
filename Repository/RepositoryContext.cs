using DataServices.Domain.Models;
using DataServices.Persistence.Mock;
using Microsoft.EntityFrameworkCore;

namespace DataServices.Domain
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
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
