using DDDFramework.Core.Domain.Models;
namespace Catalog.Core.Entities;


public class ProductBrand : BaseEntity<ProductBrand, string>
{
    public string Name { get; set; }
}