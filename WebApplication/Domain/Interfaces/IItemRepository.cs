using WebApplication.Domain.Entities;
using WebApplication.Domain.ValueObject;

namespace WebApplication.Domain.Interfaces;

public interface IItemRepository
{
    Task<IEnumerable<Item>> GetAllItemAsync(ItemId id);
    Task<Item?> GetItemByIdAsync(ItemId id);
    Task<Item> CreateItemAsync(Item item);
    Task<Item> UpdateItemAsync(Item item);
    Task<Item> DeleteItemAsync(ItemId id);
}