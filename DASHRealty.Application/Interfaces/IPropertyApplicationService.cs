using DASHRealty.Application.DTOs;
using System;
using System.Collections.Generic;

namespace DASHRealty.Application.Interfaces
{
    public interface IPropertyApplicationService
    {
        IEnumerable<PropertyDTO> GetAll();
        PropertyDTO GetById(Guid id);
        void Add(PropertyDTO propertyDTO);
        void Update(PropertyDTO propertyDTO);
        void Remove(Guid id);
    }
}
