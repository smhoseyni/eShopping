using Catalog.Contracts;
using Catalog.Core.Entities;
using Catalog.Core.Specs;

namespace Catalog.Contracts;

public interface IProductRepository
{
    Task<Pagination<ProductDto>> GetProducts(CatalogSpecParams catalogSpecParams);
    Task<ProductDto> GetProduct(string id);
    Task<IEnumerable<ProductDto>> GetProductByName(string name);
    Task<IEnumerable<ProductDto>> GetProductByBrand(string name);
    Task<ProductDto> CreateProduct(ProductDto product);
    Task<bool> UpdateProduct(ProductDto product);
    Task<bool> DeleteProduct(string id);
}