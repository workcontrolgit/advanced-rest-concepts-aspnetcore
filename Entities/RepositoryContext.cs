using Bogus;
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
        var owner = new Faker<Owner>()
        .RuleFor(m => m.Id, f => f.Random.Guid())
        .RuleFor(m => m.Name, f => f.Name.FullName())
        .RuleFor(m => m.Address, f => f.Address.FullAddress())
        .RuleFor(m => m.DateOfBirth, f => f.Date.Past());
        
        modelBuilder.Entity<Owner>()
            .HasData(owner.Generate(1000));
        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
	}
}
