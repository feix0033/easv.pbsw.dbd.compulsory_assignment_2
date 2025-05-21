namespace WebApplication.Infrastructure.Models;

public class UserDbModel
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public DateTime? DeleteTime{ get; set; }
}