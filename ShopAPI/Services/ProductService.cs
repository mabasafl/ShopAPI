using Microsoft.EntityFrameworkCore;
using ShopAPI.Data;
using ShopAPI.Dtos;
using ShopAPI.Interfaces;
using ShopAPI.Models;

namespace ShopAPI.Services
{
    public class ProductService : IProducts
    {
        private readonly ShopDataContext _dataContext;
        private readonly IMapper<Products, ProductsDto> _mapper;

        public ProductService(IMapper<Products, ProductsDto> mapper, ShopDataContext dataContext)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<List<ProductsDto>> GetAllProductsAsync()
        {
            var products = await _dataContext.Products.ToListAsync();
            return products;
        }

        public async Task<ProductsDto> GetProductAsync(int productId)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.ID == productId);

            if(product == null)
            {
                throw new Exception("No product found with Id " + productId + ".");
            }
            return product;
        }

    }
}
