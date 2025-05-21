using WebApplication.Domain.Interfaces;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Events;

public class UserChangeEvent : IDomainEvent
{
    public UserId userId { get; set; }
}