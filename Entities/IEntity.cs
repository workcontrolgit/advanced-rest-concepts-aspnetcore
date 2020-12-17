using System;
using System.Collections.Generic;
using System.Text;

namespace DataServices.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
