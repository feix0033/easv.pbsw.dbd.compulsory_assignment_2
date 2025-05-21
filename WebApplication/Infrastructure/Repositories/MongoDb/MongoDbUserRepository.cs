using WebApplication.Domain.Entities;
using WebApplication.Domain.Interfaces;
using WebApplication.Domain.ValueObject;
using WebApplication.Infrastructure.Contexts;

namespace WebApplication.Infrastructure.Repositories.MongoDb;

public class MongoDbUserRepository(MongoDbContext dbContext): IUserRepository
{
    public Task<IEnumerable<User>> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserByIdAsync(UserId id)
    {
        throw new NotImplementedException();
    }

    public Task<User> CreateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> DeleteUserAsync(UserId id)
    {
        throw new NotImplementedException();
    }
}