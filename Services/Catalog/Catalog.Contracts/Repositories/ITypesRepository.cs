using Catalog.Core.Entities;

namespace Catalog.Contracts;

public interface ITypesRepository
{
    Task<IEnumerable<ProductTypeDto>> GetAllTypes();
}