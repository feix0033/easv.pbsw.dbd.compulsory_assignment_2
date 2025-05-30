using WebApplication.Application.Services;
using WebApplication.Domain.Events;
using WebApplication.Domain.Interfaces;

namespace WebApplication.Application.Commands;

public class CreateUserCommandHandler(UserService userService, IDomainEventBus domainEventBus)
{
	public async Task HandleAsync(CreateUserCommand command)
	{
		await userService.CreateUserAsync(command.userId, command.user);
		await domainEventBus.PublishAsync(new UserCreateEvent(command.user.Username, command.user.Email, command.user.Password));
	}
}