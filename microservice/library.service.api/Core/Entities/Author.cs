using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.service.api.Core.Entities
{
    public class Author
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("academic_level")]
        public string AcademicLevel { get; set; }
    }
}
