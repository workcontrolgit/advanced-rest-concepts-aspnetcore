using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ExtendedModels
{
    public class EmployeeExtended : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public IEnumerable<Account> Accounts { get; set; }

        public EmployeeExtended()
        {
        }

        public EmployeeExtended(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            DateOfBirth = employee.DateOfBirth;
            Address = employee.Address;
        }
    }
}
