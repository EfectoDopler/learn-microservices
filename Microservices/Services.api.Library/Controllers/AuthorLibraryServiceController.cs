using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.api.Library.Core.Entities;
using Services.api.Library.Repository;

namespace Services.api.Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorLibraryServiceController : ControllerBase
    {
        private readonly IMongoRepository<AuthorEntity> _genericAuthorRepository;

        public AuthorLibraryServiceController(IMongoRepository<AuthorEntity> genericAuthorRepository) {
            _genericAuthorRepository = genericAuthorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorEntity>>> Get() {
            return Ok(await _genericAuthorRepository.GetAll());
        }

        [HttpGet("id")]
        public async Task<ActionResult<AuthorEntity>> GetById(string Id) {
            var author = await _genericAuthorRepository.GetById(Id);
            return Ok(author);
        }

        [HttpPost]
        public async Task Post(AuthorEntity author)
        {
            await _genericAuthorRepository.InsertDocument(author);
        }

        [HttpPut("id")]
        public async Task Put(string Id, AuthorEntity author) {
            author.Id = Id;
            await _genericAuthorRepository.UpdateDocument(author);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string Id) {
            await _genericAuthorRepository.DeleteById(Id);
        }
    }   
}