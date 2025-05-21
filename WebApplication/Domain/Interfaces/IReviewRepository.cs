using WebApplication.Domain.Entities;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Interfaces;

public interface IReviewRepository
{
    Task<IEnumerable<Review>> GetAllReviewsAsync();
    Task<Review?> GetReviewByIdAsync(ReviewId id);
    Task<Review> CreateReviewAsync(Review review);
    Task<Review> UpdateReviewAsync(Review review);
    Task<Review> DeleteReviewAsync(ReviewId id);
    
}