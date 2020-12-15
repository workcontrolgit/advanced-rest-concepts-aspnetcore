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
            var accountFaker = new Faker<Account>()
               .RuleFor(p => p.Id, f => Guid.NewGuid())
               .RuleFor(p => p.AccountType, f => f.Commerce.ProductMaterial())
               .RuleFor(p => p.DateCreated, f => f.Date.Recent());

            var ownerFaker = new Faker<Owner>()
               .RuleFor(b => b.Id, f => Guid.NewGuid())
               .RuleFor(b => b.Name, f => f.Name.FullName())
               .RuleFor(b => b.Id, (f, b) =>
               {
                   accountFaker.RuleFor(p => p.OwnerId, _ => b.Id);

                   var accounts = accountFaker.GenerateBetween(3, 5);

                   FakeData.Accounts.AddRange(accounts);

                   return default; // Owner.Accounts is a getter only. The return value has no impact.
               });

            var owners = ownerFaker.Generate(count);

            FakeData.Owners.AddRange(owners);
        }
    }
}
