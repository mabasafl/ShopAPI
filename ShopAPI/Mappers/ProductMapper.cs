using ShopAPI.Dtos;
using ShopAPI.Models;
using ShopAPI.Interfaces;

namespace ShopAPI.Mappers
{
    public class ProductMapper : IMapper<Products, ProductsDto>
    {
        public ProductMapper()
        {

        }

        public ProductsDto Map(Products model)
        {
            return new ProductsDto
            {
                ID = model.ID,
                ItemName = model.ItemName,
                ItemPrice = model.ItemPrice,
                ItemImage = model.ItemImage,
                ItemDescription = model.ItemDescription,
                ItemDetails = model.ItemDetails
            };
        }

        public Products Map(ProductsDto dto)
        {
            return new Products
            {
                ID = dto.ID,
                ItemDescription = dto.ItemDescription,
                ItemDetails = dto.ItemDetails,
                ItemImage = dto.ItemImage,
                ItemPrice = dto.ItemPrice,
                ItemName = dto.ItemName
            };
        }
    }
}
