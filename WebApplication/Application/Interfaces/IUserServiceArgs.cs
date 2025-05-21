using WebApplication.Domain.Interfaces;

namespace WebApplication.Application.Interfaces;

public interface IUserServiceArgs
{
    IUserRepository UserPersistenceRepository { get; set; }
    IUserRepository UserCacheRepository { get; set; }
}