using Bogus;
using Bogus.Extensions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Helpers
{
    static class FakeData
    {
        public static List<Owner> Owners = new List<Owner>();
        public static List<Account> Accounts = new List<Account>();

        public static void Init(int count)
        {
            var ownerFaker = new Faker<Owner>()
            .RuleFor(m => m.Id, f => f.Random.Guid())
            .RuleFor(m => m.Name, f => f.Name.FullName())
            .RuleFor(m => m.Address, f => f.Address.FullAddress())
            .RuleFor(m => m.DateOfBirth, f => f.Date.Past());

            var owners = ownerFaker.Generate(count);

            Owners.AddRange(owners);


            var accountFaker = new Faker<Account>()
               .RuleFor(p => p.Id, f => f.Random.Guid())
               .RuleFor(p => p.AccountType, f => f.Commerce.ProductMaterial())
               .RuleFor(p => p.DateCreated, f => f.Date.Recent())
               .RuleFor(p => p.OwnerId, f => f.PickRandom(owners).Id);

            var accounts = accountFaker.Generate(count);

            Accounts.AddRange(accounts);


            //var accountFaker = new Faker<Account>()
            //   .RuleFor(p => p.Id, f => f.Random.Guid())
            //   .RuleFor(p => p.AccountType, f => f.Commerce.ProductMaterial())
            //   .RuleFor(p => p.DateCreated, f => f.Date.Recent())
            //   .RuleFor(p => p.OwnerId, (f, b) =>
            //   {
            //       ownerFaker.RuleFor(p => p.Id, _ => b.OwnerId);
            //       var owners = ownerFaker.GenerateBetween(3, 5);
            //       FakeData.Owners.AddRange(owners);
            //       return default;
            //   });
            //var ownerFaker = new Faker<Owner>()
            //   .RuleFor(b => b.Id, f => f.Random.Guid())
            //   .RuleFor(b => b.Name, f => f.Name.FullName())
            //   .RuleFor(b => b.Id, (f, b) =>
            //   {
            //       accountFaker.RuleFor(p => p.OwnerId, _ => b.Id);

            //       var accounts = accountFaker.GenerateBetween(3, 5);

            //       FakeData.Accounts.AddRange(accounts);

            //       return default; // Owner.Accounts is a getter only. The return value has no impact.
            //   });

        }
    }
}
