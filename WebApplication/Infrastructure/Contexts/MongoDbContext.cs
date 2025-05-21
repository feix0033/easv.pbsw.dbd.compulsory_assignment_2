using MongoDB.Driver;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Infrastructure.Contexts;

public class MongoDbContext
{
    public readonly IMongoCollection<ItemDbModel> Items;
    public readonly IMongoCollection<OrderDbModel> Orders;
    public readonly IMongoCollection<ReviewDbModel> Reviews;
    public readonly IMongoCollection<UserDbModel> Users;

    public MongoDbContext(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        Items = database.GetCollection<ItemDbModel>("Items");
        Orders = database.GetCollection<OrderDbModel>("Orders");
        Reviews = database.GetCollection<ReviewDbModel>("Reviews");
        Users = database.GetCollection<UserDbModel>("Users");
    }
}