using Microsoft.EntityFrameworkCore;
using ShopAPI.Data;
using ShopAPI.Dtos;
using ShopAPI.Interfaces;

namespace ShopAPI.Services
{
    public class ProductService : IProducts
    {
        private readonly ShopDataContext _dataContext;

        public ProductService(ShopDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<ProductsDto>> GetAllProductsAsync()
        {
            var products = await _dataContext.Products.ToListAsync();
            return products;
        }

        public async Task<ProductsDto> GetProductAsync(int productId)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.ID == productId);
            return product;
        }

    }
}
