using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices.Core.Application.Interfaces
{
    public interface IRepositoryWrapper
    {
        IEmployeeRepository Employee { get; }
        IAssignmentRepository Assignment { get; }
		void Save();
	}
}
