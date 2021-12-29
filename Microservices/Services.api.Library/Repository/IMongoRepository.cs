using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.api.Library.Core.Entities;

namespace Services.api.Library.Repository
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> GetAll();
    }
}
