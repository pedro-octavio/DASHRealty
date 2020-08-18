using DASHRealty.Domain.Core.Interfaces.Repositories;
using DASHRealty.Domain.Core.Interfaces.Services;
using DASHRealty.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace DASHRealty.Domain.Services.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IValidator<Property> _validator;

        public PropertyService(IPropertyRepository propertyRepository, IValidator<Property> validator)
        {
            _propertyRepository = propertyRepository;
            _validator = validator;
        }

        public IEnumerable<Property> GetAll()
        {
            try
            {
                return _propertyRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Property GetById(Guid id)
        {
            try
            {
                return _propertyRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Property property)
        {
            try
            {
                var validatorResult = _validator.Validate(property);

                if (!validatorResult.IsValid) throw new Exception(validatorResult.Errors[0].ErrorMessage);

                _propertyRepository.Add(property);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Property property)
        {
            try
            {
                var validatorResult = _validator.Validate(property);

                if (!validatorResult.IsValid) throw new Exception(validatorResult.Errors[0].ErrorMessage);

                _propertyRepository.Update(property);
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
                _propertyRepository.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
