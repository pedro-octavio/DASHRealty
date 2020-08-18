using DASHRealty.Application.DTOs;

namespace DASHRealty.Application.Interfaces
{
    public interface ITokenApplicationService
    {
        string GenerateToken(UserDTO userDTO);
    }
}
