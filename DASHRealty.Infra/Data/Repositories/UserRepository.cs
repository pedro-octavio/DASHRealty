using DASHRealty.Domain.Core.Interfaces.Repositories;
using DASHRealty.Domain.Entities;
using System;
using System.Linq;

namespace DASHRealty.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

        public User GetByEmail(string email)
        {
            try
            {
                return _applicationDbContext.Users.Where(x => x.Email == email).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
