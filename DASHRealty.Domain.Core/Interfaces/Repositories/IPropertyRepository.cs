using DASHRealty.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DASHRealty.Domain.Core.Interfaces.Repositories
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
        Property GetById(Guid id);
        void Add(Property property);
        void Update(Property property);
        void Remove(Guid id);
    }
}
