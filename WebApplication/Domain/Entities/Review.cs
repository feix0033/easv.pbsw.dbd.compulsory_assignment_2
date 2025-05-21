using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Entities;

public class Review
{
    public ReviewId Id { get; set; }
    public UserId ReviewerId { get; set; }
    public UserId SellerId { get; set; }
    public string? Content { get; set; }
    public DateTime DeleteTime { get; set; }
}