using DASHRealty.Application.DTOs;

namespace DASHRealty.Application.Interfaces
{
    public interface IUserApplicationService
    {
        UserDTO GetByEmail(string email);
    }
}
