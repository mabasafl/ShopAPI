using ShopAPI.Dtos;

namespace ShopAPI.Interfaces
{
    public interface IProducts
    {
        Task<List<ProductsDto>> GetAllProductsAsync();
        Task<ProductsDto> GetProductAsync(int productId);
    }
}
