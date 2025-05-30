using WebApplication.Application.Interfaces;
using WebApplication.Domain.Entities;
using WebApplication.Domain.Interfaces;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Application.Services;

public class UserServiceArgs : IUserServiceArgs
{
    public required IUserRepository UserPersistenceRepository;
    public required IUserRepository UserCacheRepository;

	IUserRepository IUserServiceArgs.UserPersistenceRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	IUserRepository IUserServiceArgs.UserCacheRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

public class UserService(IUserServiceArgs args)
{
    private readonly IUserRepository _userPersistenceRepository = args.UserPersistenceRepository;
    private readonly IUserRepository _userCacheRepository = args.UserCacheRepository;

    public async Task<User?> GetUserByIdAsync(string id)
    {
        UserId userId = new UserId(id);

        User? cachedUser = await _userCacheRepository.GetUserByIdAsync(userId);
        if (cachedUser != null)
            return cachedUser;

        User? user = await _userPersistenceRepository.GetUserByIdAsync(userId);
        if (user != null)
            await _userCacheRepository.CreateUserAsync(user);
        return user;
    }


    public Task<User> UpdateUserContentAsync(UserId userId, User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> CreateUserAsync(UserId userId, User user)
    {
        throw new NotImplementedException();
    }

}