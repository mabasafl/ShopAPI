using Microsoft.EntityFrameworkCore;
using ShopAPI.Dtos;

namespace ShopAPI.Data
{
    public class ShopDataContext : DbContext
    {
        public ShopDataContext(DbContextOptions<ShopDataContext> options) : base(options)
        {

        }
        public DbSet<ProductsDto> Products { get; set; }
        
    }
}
