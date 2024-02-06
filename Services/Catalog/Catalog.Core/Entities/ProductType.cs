
using DDDFramework.Core.Domain.Models;
namespace Catalog.Core.Entities;

public class ProductType : DDDFramework.Core.Domain.Models.BaseEntity<ProductType, string>  
{

    public required string Name { get; set; }
}