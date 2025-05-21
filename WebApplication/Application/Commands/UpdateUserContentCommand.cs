using WebApplication.Domain.ValueObject;

namespace WebApplication.Application.Commands;

public record UpdateUserContentCommand(UserId UserId, string Content);