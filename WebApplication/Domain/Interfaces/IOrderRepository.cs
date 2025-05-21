using WebApplication.Domain.Entities;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Interfaces;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();
    Task<Order?> GetOrderByIdAsync(OrderId id);
    Task<Order> CreateOrderAsync(Order order);
    Task<Order> UpdateOrderAsync(Order order);
    Task<Order> DeleteOrderAsync(OrderId id);
}