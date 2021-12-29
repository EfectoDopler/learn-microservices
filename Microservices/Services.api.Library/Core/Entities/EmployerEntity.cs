using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.api.Library.Core.Entities
{

    [BsonCollection("Employer")]
    public class EmployerEntity : Document
    {
        [BsonElement("name")]
        public string Name { get; set; }
    }
}
