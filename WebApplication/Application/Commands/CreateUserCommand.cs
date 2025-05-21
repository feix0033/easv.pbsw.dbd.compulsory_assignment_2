using WebApplication.Domain.Entities;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Application.Commands;

public record CreateUserCommand(UserId userId, User user);