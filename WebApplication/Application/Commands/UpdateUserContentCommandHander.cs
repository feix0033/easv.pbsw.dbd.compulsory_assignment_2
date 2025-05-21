using System.Linq.Expressions;
using WebApplication.Application.Services;
using WebApplication.Domain.Events;
using WebApplication.Domain.Interfaces;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Application.Commands;

public class UpdateUserContentCommandHandler(UserService userService, IDomainEventBus domainEventBus)
{
	public async Task HandleAsync(UpdateUserContentCommand command)
	{
		await userService.UpdateUserContentAsync(command.UserId, command.Content);
		await domainEventBus.PublishAsync(new UserChangeEvent { userId = command.UserId });
	}

}