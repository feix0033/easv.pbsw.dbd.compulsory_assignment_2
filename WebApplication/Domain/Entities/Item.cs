using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Entities;

public class Item
{
    public ItemId Id { get; set; }
    public UserId SellerId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool IsSold { get; set; }
    public DateTime DeleteTime { get; set; }
}