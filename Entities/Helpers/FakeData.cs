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
        public static List<Employee> Employees = new List<Employee>();
        public static List<Assignment> Assignments = new List<Assignment>();

        public static void Init(int count)
        {
            var employeeFaker = new Faker<Employee>()
            .RuleFor(m => m.Id, f => f.Random.Guid())
            .RuleFor(m => m.Name, f => f.Name.FullName())
            .RuleFor(m => m.Address, f => f.Address.FullAddress())
            .RuleFor(m => m.DateOfBirth, f => f.Date.Past());

            var employees = employeeFaker.Generate(count);

            Employees.AddRange(employees);


            var assignmentFaker = new Faker<Assignment>()
               .RuleFor(p => p.Id, f => f.Random.Guid())
               .RuleFor(p => p.AssignmentType, f => f.Commerce.ProductMaterial())
               .RuleFor(p => p.DateCreated, f => f.Date.Recent())
               .RuleFor(p => p.EmployeeId, f => f.PickRandom(employees).Id);

            var assignments = assignmentFaker.Generate(count);

            Assignments.AddRange(assignments);


            //var assignmentFaker = new Faker<Assignment>()
            //   .RuleFor(p => p.Id, f => f.Random.Guid())
            //   .RuleFor(p => p.AssignmentType, f => f.Commerce.ProductMaterial())
            //   .RuleFor(p => p.DateCreated, f => f.Date.Recent())
            //   .RuleFor(p => p.EmployeeId, (f, b) =>
            //   {
            //       employeeFaker.RuleFor(p => p.Id, _ => b.EmployeeId);
            //       var employees = employeeFaker.GenerateBetween(3, 5);
            //       FakeData.Employees.AddRange(employees);
            //       return default;
            //   });
            //var employeeFaker = new Faker<Employee>()
            //   .RuleFor(b => b.Id, f => f.Random.Guid())
            //   .RuleFor(b => b.Name, f => f.Name.FullName())
            //   .RuleFor(b => b.Id, (f, b) =>
            //   {
            //       assignmentFaker.RuleFor(p => p.EmployeeId, _ => b.Id);

            //       var assignments = assignmentFaker.GenerateBetween(3, 5);

            //       FakeData.Assignments.AddRange(assignments);

            //       return default; // Employee.Assignments is a getter only. The return value has no impact.
            //   });

        }
    }
}
