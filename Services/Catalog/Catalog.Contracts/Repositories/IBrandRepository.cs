using Catalog.Core.Entities;

namespace Catalog.Contracts;

public interface IBrandRepository
{
    Task<IEnumerable<ProductBrandDto>> GetAllBrands();
}