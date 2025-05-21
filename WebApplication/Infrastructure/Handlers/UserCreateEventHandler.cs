using WebApplication.Domain.Events;
using WebApplication.Domain.Interfaces;
using WebApplication.Infrastructure.Events;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Infrastructure.Handlers;

public class UserCreateEventHandler
{
    public UserCreateEventHandler(InMemoryEventBus eventBus, IUserRepository userRepository)
    {
        eventBus.Subscribe<UserCreateEvent>(async evt =>
        {
            UserDbModel userDbModel = new UserDbModel
            {

            };

            // await userRepository.CreateUserAsync();
        });
    }
}