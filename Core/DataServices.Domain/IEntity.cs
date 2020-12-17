using System;

namespace DataServices.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
