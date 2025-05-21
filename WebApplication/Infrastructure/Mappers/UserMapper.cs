using WebApplication.Domain.Entities;
using WebApplication.Domain.ValueObject;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Infrastructure.Mappers;

public static class UserMapper
{
    public static User ToDomain(this UserDbModel user)
    {
        return new User
        {
            Id = new UserId(user.Id),
            Email = user.Email,
            Password = user.Password,
        };
    }

    public static UserDbModel ToMongoDb(this User user)
    {
        return new UserDbModel
        {
            Id = user.Id.Value,
            Email = user.Email,
            Password = user.Password,
            DeleteTime = user.DeleteTime,
        };
    }
}