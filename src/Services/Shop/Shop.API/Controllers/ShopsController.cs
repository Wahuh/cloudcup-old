using Microsoft.AspNetCore.Mvc;
using Shop.API.Models;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ShopsController : ControllerBase
  {
    private readonly ShopContext _context;
    public ShopsController(ShopContext context)
    {
      _context = context;
    }

    public void GetShop()
    {

    }
  
    [HttpPost]
    public async Task<ActionResult<ShopModel>> PostShop(ShopModel shop)
    {
      _context.Shops.Add(shop);
      await _context.SaveChangesAsync();
      return CreatedAtAction("GetShop", new { id = shop.Id }, shop);
    }
  }
}