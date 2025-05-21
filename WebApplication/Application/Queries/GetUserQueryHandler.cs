using WebApplication.Application.Services;
using WebApplication.Domain.Entities;

namespace WebApplication.Application.Queries;

public class GetUserQueryHandler(UserService userService)
{
    public async Task<User?> HandleAsync(GetUserQuery query)
    {
        return await userService.GetUserByIdAsync(query.UserId);
    }

    public async Task<User?> HandleAsync(string userId)
    {
        return await userService.GetUserByIdAsync(userId);
    }
}