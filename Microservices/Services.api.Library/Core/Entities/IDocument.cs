using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.api.Library.Core.Entities
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        DateTime CreatedDate { get;  }
    }
}
