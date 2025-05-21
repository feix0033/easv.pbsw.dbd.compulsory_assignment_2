using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Entities;

public class Order
{
    public OrderId Id { get; set; }
    public UserId UserId { get; set; }
    public bool IsCheckedout { get; set; }
    public DateTime CheckoutDate { get; set; }
    public List<Item>? OrderItems { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime DeleteTime { get; set; }
}