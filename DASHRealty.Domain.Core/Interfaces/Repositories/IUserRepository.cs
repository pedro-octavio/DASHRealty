using DASHRealty.Domain.Entities;

namespace DASHRealty.Domain.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
    }
}
