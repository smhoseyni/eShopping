using Catalog.Core.Entities;
using MongoDB.Driver;
using Catalog.Contracts;

namespace Catalog.Infrastructure.Data;

public interface ICatalogContext
{
    IMongoCollection<ProductDto> Products { get; }
    IMongoCollection<ProductBrandDto> Brands { get; }
    IMongoCollection<ProductTypeDto> Types { get; }
}