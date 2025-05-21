using System.Collections.Concurrent;
using MongoDB.Driver.Search;
using WebApplication.Domain.Interfaces;

namespace WebApplication.Infrastructure.Events;

public class InMemoryEventBus: IDomainEventBus
{
    private readonly ConcurrentDictionary<Type, List<Func<IDomainEvent, Task>>> _handlers = new();
    
    public void Subscribe<T>(Func<T, Task> handler) where T : IDomainEvent
    {
        var handlers = _handlers.GetOrAdd(typeof(T), _ => new());
        handlers.Add(evt => handler((T)evt));
    }

    public Task PublishAsync(IDomainEvent domainEvent)
    {
        if (_handlers.TryGetValue(domainEvent.GetType(), out var handlers))
        {
            return Task.WhenAll(handlers.Select(h => h(domainEvent)));
        }

        return Task.CompletedTask;
    }
}