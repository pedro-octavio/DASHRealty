using DASHRealty.Domain.Entities;

namespace DASHRealty.Domain.Core.Interfaces.Services
{
    public interface IUserService
    {
        User GetByEmail(string email);
    }
}
