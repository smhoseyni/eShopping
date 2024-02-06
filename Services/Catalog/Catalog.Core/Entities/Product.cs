
using DDDFramework.Core.Domain.Models;
namespace Catalog.Core.Entities;

public class Product : BaseEntity<Product, string>
{
    public Product(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        Name = name;
    }

    public string Name { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }
    public ProductBrand Brands { get; set; }
    public ProductType Types { get; set; }
    public decimal Price { get; set; }
}