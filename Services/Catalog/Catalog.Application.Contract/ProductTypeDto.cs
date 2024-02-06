using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog;

    public class ProductTypeDto
    {
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }

