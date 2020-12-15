using Bogus;
using Entities.Helpers;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var employee = new Faker<Employee>()
            //.RuleFor(m => m.Id, f => f.Random.Guid())
            //.RuleFor(m => m.Name, f => f.Name.FullName())
            //.RuleFor(m => m.Address, f => f.Address.FullAddress())
            //.RuleFor(m => m.DateOfBirth, f => f.Date.Past());

            //modelBuilder.Entity<Employee>()
            //    .HasData(employee.Generate(1000));
            FakeData.Init(1000);

            modelBuilder.Entity<Employee>().HasData(FakeData.Employees);
            modelBuilder.Entity<Account>().HasData(FakeData.Accounts);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
	}
}
