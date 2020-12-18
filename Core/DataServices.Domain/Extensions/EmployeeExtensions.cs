using DataServices.Core.Domain.Entities;

namespace DataServices.Core.Domain.Extensions
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
