using WebApplication.Domain.Entities;

namespace WebApplication.Infrastructure.Models;

public class UserMongoDbModel
{
	public string Id { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public string Username { get; set; }

	public Item[] Items { get; set; }

	public Order[] Orders { get; set; }

	public Review[] Reviews { get; set; }
	public DateTime? DeleteTime { get; set; }
}