using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IEmployeeRepository Employee { get; }
        IAccountRepository Account { get; }
		void Save();
	}
}
