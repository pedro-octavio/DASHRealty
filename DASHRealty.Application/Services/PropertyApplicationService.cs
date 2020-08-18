using AutoMapper;
using DASHRealty.Application.DTOs;
using DASHRealty.Application.Interfaces;
using DASHRealty.Domain.Core.Interfaces.Services;
using DASHRealty.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DASHRealty.Application.Services
{
    public class PropertyApplicationService : IPropertyApplicationService
    {
        private readonly IPropertyService _propertyService;
        private readonly IMapper _mapper;

        public PropertyApplicationService(IPropertyService propertyService, IMapper mapper)
        {
            _propertyService = propertyService;
            _mapper = mapper;
        }

        public IEnumerable<PropertyDTO> GetAll()
        {
            try
            {
                var properties = _propertyService.GetAll();

                return _mapper.Map<IEnumerable<PropertyDTO>>(properties);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PropertyDTO GetById(Guid id)
        {
            try
            {
                var property = _propertyService.GetById(id);

                return _mapper.Map<PropertyDTO>(property);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(PropertyDTO propertyDTO)
        {
            try
            {
                var property = _mapper.Map<Property>(propertyDTO);

                property.Id = Guid.NewGuid();

                _propertyService.Add(property);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(PropertyDTO propertyDTO)
        {
            try
            {
                var property = _mapper.Map<Property>(propertyDTO);

                _propertyService.Update(property);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(Guid id)
        {
            try
            {
                _propertyService.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
