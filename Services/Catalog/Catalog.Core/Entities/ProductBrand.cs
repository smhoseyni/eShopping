using DDDFramework.Core.Domain.Models;
namespace Catalog.Core.Entities;


public class ProductBrand : BaseEntity<ProductBrand, Guid>
{
    public string Name { get; set; }
}