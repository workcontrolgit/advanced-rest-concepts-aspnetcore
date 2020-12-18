using DataServices.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices.Core.Domain.ExtendedModels
{
    public class EmployeeExtended : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public IEnumerable<Assignment> Assignments { get; set; }

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
