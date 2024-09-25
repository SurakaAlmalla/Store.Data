using Store.Service.Services.ProductService.Dtos;

namespace Store.Service.Services.ProductService
{
    public interface IProuductService
    {
        Task<ProuductDetailsDto> GetProductByIdAsync(int? productId);
        Task<IReadOnlyList<ProuductDetailsDto>> GetAllProductAsync();
        Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllBrandsAsync();
        Task<IReadOnlyList<BrandTypeDetailsDto>> GetAllTypesAsync();

    }
}
