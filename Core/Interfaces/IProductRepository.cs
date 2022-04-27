using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
         Task<Product> GetProductByIdAsync(int id);
         Task<IReadOnlyList<Product>> GetProductListAsync();
         Task<IReadOnlyList<ProductBrand>> GetProductBrandListAsync();
         Task<IReadOnlyList<ProductType>> GetProductTypeListAsync();
    }
}