using Catalog.Core.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Catalog.Contracts;

namespace Catalog.Infrastructure.Data;

public class CatalogContext : ICatalogContext
{
    public IMongoCollection<ProductDto> Products { get; }
    public IMongoCollection<ProductBrandDto> Brands { get; }
    public IMongoCollection<ProductTypeDto> Types { get; }

    public CatalogContext(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
        var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
        Brands = database.GetCollection<ProductBrandDto>(
            configuration.GetValue<string>("DatabaseSettings:BrandsCollection"));
        Types = database.GetCollection<ProductTypeDto>(
            configuration.GetValue<string>("DatabaseSettings:TypesCollection"));
        Products = database.GetCollection<ProductDto>(
            configuration.GetValue<string>("DatabaseSettings:CollectionName"));
        
        BrandContextSeed.SeedData(Brands);
        TypeContextSeed.SeedData(Types);
        CatalogContextSeed.SeedData(Products);
    }
}