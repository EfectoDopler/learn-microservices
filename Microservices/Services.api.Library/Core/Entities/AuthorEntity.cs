using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.api.Library.Core.Entities
{
    [BsonCollection("Author")]
    public class AuthorEntity : Document
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("lastname")]
        public string Lastname { get; set; }
        [BsonElement("studies")]
        public string Studies { get; set; }
    }
}
