using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Catalog.Application.Contract;

public class ProductDto
{
    [BsonId]
    [BsonRepresentation(BsonType.String)] // Store the Guid as a string for better readability or BsonType.Binary for efficiency
    public Guid Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("summary")]
    public string Summary { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }

    [BsonElement("imageFile")]
    public string ImageFile { get; set; }


    [BsonElement("brand")]
    public ProductBrandDto Brand { get; set; } // Use the DTO representation of ProductBrand


    [BsonElement("types")]
    public string Types { get; set; } // Assuming conversion to string if not stored as a complex object

    [BsonElement("price")]
    [BsonRepresentation(BsonType.Decimal128)] // MongoDB supports high precision decimal for financial data
    public decimal Price { get; set; }

}
