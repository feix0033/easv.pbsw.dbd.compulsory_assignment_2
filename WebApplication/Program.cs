using WebApplication.Application.Commands;
using WebApplication.Application.Interfaces;
using WebApplication.Application.Queries;
using WebApplication.Application.Services;
using WebApplication.Domain.Interfaces;
using WebApplication.Infrastructure.Cache;
using WebApplication.Infrastructure.Contexts;
using WebApplication.Infrastructure.Events;
using WebApplication.Infrastructure.Handlers;
using WebApplication.Infrastructure.Repositories.MongoDb;
using WebApplication.Infrastructure.Repositories.Redis;


var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Register repositories
builder.Services.AddScoped<IUserServiceArgs>(services =>
{
    var mongoDbContext = new MongoDbContext("mongodb://localhost:27017", "mongo-example");
    var redisDbContext = new RedisDbContext("localhost:6379");
    var mongoDbUserRepository = new MongoDbUserRepository(mongoDbContext);
    var redisUserRepository = new RedisUserRepository(redisDbContext, TimeSpan.FromHours(1));

    return new UserServiceArgs
    {
        UserPersistenceRepository = mongoDbUserRepository,
        UserCacheRepository = redisUserRepository
    };
});

// Register services
builder.Services.AddScoped<GetUserQueryHandler>();
builder.Services.AddScoped<UpdateUserContentCommandHandler>();
builder.Services.AddScoped<CreateUserCommandHandler>();

// Register event bus
builder.Services.AddSingleton<InMemoryEventBus>();

// Register event publisher
builder.Services.AddSingleton<IDomainEventBus>(sp => sp.GetRequiredService<InMemoryEventBus>());

// Register event handlers
builder.Services.AddSingleton<UserCreateEventHandler>();
builder.Services.AddSingleton<UserCacheInvalidationHandler>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();