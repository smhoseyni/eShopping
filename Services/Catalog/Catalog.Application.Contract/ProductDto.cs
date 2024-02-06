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
    [BsonRepresentation(BsonType.String)] 
    public string Id { get; set; }

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
    public ProductTypeDto Types { get; set; } 

    [BsonElement("price")]
    [BsonRepresentation(BsonType.Decimal128)] // MongoDB supports high precision decimal for financial data
    public decimal Price { get; set; }

}
