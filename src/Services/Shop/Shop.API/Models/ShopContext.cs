using Microsoft.EntityFrameworkCore;

namespace Shop.API.Models
{
  public class ShopContext : DbContext
  {
    public ShopContext(DbContextOptions<ShopContext> options) : base(options)
    {

    }
    public DbSet<ShopModel> Shops { get; set; }
  }
}