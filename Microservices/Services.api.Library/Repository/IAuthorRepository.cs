using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Services.api.Library.Core.Entities;

namespace Services.api.Library.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthors();
    }
}
