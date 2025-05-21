namespace WebApplication.Infrastructure.Models;

public class OrderMongoDbModel
{
	public string Id { get; set; }
	public string BuyerId { get; set; }
	public bool IsCheckedout { get; set; }
	public DateTime? CheckoutDate { get; set; }
	public decimal? TotalAmount { get; set; }

	public List<ItemMongoDbModel>? Items { get; set; }
}