using DASHRealty.Domain.Core.Interfaces.Repositories;
using DASHRealty.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DASHRealty.Infra.Data.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PropertyRepository(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

        public IEnumerable<Property> GetAll()
        {
            try
            {
                return _applicationDbContext.Properties.ToList();
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
                return _applicationDbContext.Properties.Find(id);
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
                _applicationDbContext.Properties.Add(property);

                _applicationDbContext.SaveChanges();
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
                _applicationDbContext.Properties.Update(property);

                _applicationDbContext.SaveChanges();
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
                _applicationDbContext.Properties.Remove(GetById(id));

                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
