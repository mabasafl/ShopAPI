namespace ShopAPI.Dtos
{
    public class ProductsDto
    {
        public int ID { get; set; }
        public string? ItemName { get; set; }
        public string? ItemImage { get; set; }
        public string? ItemPrice { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemDetails { get; set; }
    }
}
