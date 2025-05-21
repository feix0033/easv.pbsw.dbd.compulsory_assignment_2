using WebApplication.Domain.Events;
using WebApplication.Domain.Interfaces;
using WebApplication.Infrastructure.Events;

namespace WebApplication.Infrastructure.Cache;

public class UserCacheInvalidationHandler
{
    private readonly IUserRepository _cacheRepository;

    public UserCacheInvalidationHandler(InMemoryEventBus eventBus, IUserRepository userRepository)
    {
        _cacheRepository = userRepository;
        eventBus.Subscribe<UserChangeEvent>(HandleAsync);
    }

    private async Task HandleAsync(UserChangeEvent evt)
    {
        await _cacheRepository.DeleteUserAsync(evt.userId);
    }
}