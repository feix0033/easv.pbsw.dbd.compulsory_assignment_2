namespace WebApplication.Infrastructure.Models;

public class ItemDbModel
{
    public string Id { get; set; }
    public string SellerId { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
    public decimal price { get; set; }
    public string? imageUrl { get; set; }
    public bool isSold { get; set; }
    public DateTime? deleteTime { get; set; }
    
}