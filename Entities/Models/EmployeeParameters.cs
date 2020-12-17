using System;

namespace DataServices.Domain.Models
{
	public class EmployeeParameters : QueryStringParameters
	{
		public EmployeeParameters()
		{
			OrderBy = "name";
		}

		public uint MinYearOfBirth { get; set; }
		public uint MaxYearOfBirth { get; set; } = (uint)DateTime.Now.Year;

		public bool ValidYearRange => MaxYearOfBirth > MinYearOfBirth;

		public string Name { get; set; }
	}
}
