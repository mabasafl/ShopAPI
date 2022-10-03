namespace ShopAPI.Interfaces
{
    public interface IMapper<TDto, TModel>
    {
        TDto Map(TModel model);
        TModel Map(TDto dto);
    }
}
