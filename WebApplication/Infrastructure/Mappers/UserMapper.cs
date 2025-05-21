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
            DeleteTime = user.DeleteTime
        };
    }

    public static UserMongoDbModel ToMongoDb(this User user, Order[] orders, Item[] items, Review[] reviews)
    {
        return new UserMongoDbModel
        {
            Id = user.Id.Value,
            Email = user.Email,
            Password = user.Password,
            DeleteTime = user.DeleteTime,
            Items = items,
            Orders = orders,
            Reviews = reviews
        };
    }
}