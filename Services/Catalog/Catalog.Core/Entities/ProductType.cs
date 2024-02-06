
using DDDFramework.Core.Domain.Models;
namespace Catalog.Core.Entities;

public class ProductType : DDDFramework.Core.Domain.Models.BaseEntity<ProductType, Guid>  
{
    public string Name { get; set; }
}