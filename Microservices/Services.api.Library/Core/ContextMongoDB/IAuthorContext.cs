using System;
using MongoDB.Driver;
using Services.api.Library.Core.Entities;

namespace Services.api.Library.Core.ContextMongoDB
{ 
    public interface IAuthorContext
    {
        IMongoCollection<Author> Authors { get; }
    }
}
