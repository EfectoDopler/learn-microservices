using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.api.Library.Core.Entities
{
    public class Author
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("lastname")]
        public string Lastname { get; set; }

        [BsonElement("studies")]
        public string Studies { get; set; }
        public Author()
        {
        }
    }
}
