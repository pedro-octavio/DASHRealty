using DASHRealty.Domain.Core.Interfaces.Repositories;
using DASHRealty.Domain.Core.Interfaces.Services;
using DASHRealty.Domain.Entities;
using System;

namespace DASHRealty.Domain.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) => _userRepository = userRepository;

        public User GetByEmail(string email)
        {
            try
            {
                return _userRepository.GetByEmail(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
