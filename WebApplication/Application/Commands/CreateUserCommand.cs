using WebApplication.Domain.ValueObject;

namespace WebApplication.Application.Commands;

public record CreateUserCommand(string username, string email, string password);