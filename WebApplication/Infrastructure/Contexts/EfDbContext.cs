using Microsoft.EntityFrameworkCore;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Infrastructure.Contexts;

public class EfDbContext(DbContextOptions<EfDbContext> options) : DbContext(options)
{
    public DbSet<UserDbModel> Users { get; set; }
    public DbSet<OrderDbModel> Orders { get; set; }
    public DbSet<ItemDbModel> Items { get; set; }
    public DbSet<OrderItemsDbModel> OrderItems { get; set; }
    public DbSet<ReviewDbModel> Reviews { get; set; }
}