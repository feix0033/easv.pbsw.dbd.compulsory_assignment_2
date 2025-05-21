using WebApplication.Domain.Interfaces;

namespace WebApplication.Domain.Events;

public class UserCreateEvent(string username, string email, string password) : IDomainEvent
{
}