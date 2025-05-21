namespace WebApplication.Infrastructure.Models;

public class OrderDbModel
{
    public string Id { get; set; }
    public string BuyerId { get; set; }
    public bool isCheckedout { get; set; }
    public decimal? totalPrice { get; set; }
    public DateTime? deleteDate  { get; set; }
}