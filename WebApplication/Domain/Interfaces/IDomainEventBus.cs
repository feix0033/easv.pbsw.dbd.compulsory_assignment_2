namespace WebApplication.Domain.Interfaces;

public interface IDomainEventBus
{
    public void Subscribe<T>(Func<T, Task> handler) where T : IDomainEvent;
    public Task PublishAsync(IDomainEvent domainEvent);
}