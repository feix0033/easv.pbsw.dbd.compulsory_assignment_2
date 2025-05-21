namespace WebApplication.Infrastructure.Models;

public class ReviewDbModel
{
    public string Id { get; set; }
    public string ReviewerId { get; set; }
    public string SellerId { get; set; }
    public string Content { get; set; }
    public DateTime deleteDate { get; set; }
}