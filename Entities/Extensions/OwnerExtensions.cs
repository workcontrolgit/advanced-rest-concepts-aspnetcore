using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Extensions
{
    public static class EmployeeExtensions
    {
        public static void Map(this Employee dbEmployee, Employee employee)
        {
            dbEmployee.Name = employee.Name;
            dbEmployee.Address = employee.Address;
            dbEmployee.DateOfBirth = employee.DateOfBirth;
        }
    }
}
