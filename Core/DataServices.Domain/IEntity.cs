using System;

namespace DataServices.Core.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
