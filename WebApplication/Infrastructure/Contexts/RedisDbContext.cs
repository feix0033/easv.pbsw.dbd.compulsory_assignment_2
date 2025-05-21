using StackExchange.Redis;

namespace WebApplication.Infrastructure.Contexts;

public class RedisDbContext
{
    private readonly IDatabase _db;

    public RedisDbContext(string connectionString)
    {
        IConnectionMultiplexer redis = ConnectionMultiplexer.Connect(connectionString);
        _db = redis.GetDatabase();
    }

    public IDatabase GetDatabase()
    {
        return _db;
    }
}