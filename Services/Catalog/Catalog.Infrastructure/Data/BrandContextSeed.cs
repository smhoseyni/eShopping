using System.Text.Json;
using MongoDB.Driver;
using Catalog.Contracts;

namespace Catalog.Infrastructure.Data;

public static class BrandContextSeed
{
    public static void SeedData(IMongoCollection<ProductBrandDto> brandCollection)
    {
        bool checkBrands = brandCollection.Find(b => true).Any();
        string path = Path.Combine("Data", "SeedData", "brands.json");
        if (!checkBrands)
        {
            var brandsData = File.ReadAllText(path);
            var brands = JsonSerializer.Deserialize<List<ProductBrandDto>>(brandsData);
            if (brands != null)
            {
                foreach (var item in brands)
                {
                    brandCollection.InsertOneAsync(item);
                }
            }
        }
    } 
}