using AutoMapper;
using DASHRealty.Application.DTOs;
using DASHRealty.Application.Interfaces;
using DASHRealty.Domain.Core.Interfaces.Services;
using System;

namespace DASHRealty.Application.Services
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserApplicationService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public UserDTO GetByEmail(string email)
        {
            try
            {
                var user = _userService.GetByEmail(email);

                return _mapper.Map<UserDTO>(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
