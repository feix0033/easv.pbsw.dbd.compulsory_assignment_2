using MongoDB.Driver;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Infrastructure.Contexts;

public class MongoDbContext
{
    public readonly IMongoCollection<UserMongoDbModel> Users;
    public readonly IMongoCollection<OrderMongoDbModel> Orders;

    public MongoDbContext(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        Users = database.GetCollection<UserMongoDbModel>("Users");
        Orders = database.GetCollection<OrderMongoDbModel>("Orders");
    }
}