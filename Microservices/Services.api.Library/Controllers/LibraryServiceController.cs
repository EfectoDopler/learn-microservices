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
    public class LibraryServiceController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMongoRepository<AuthorEntity> _genericAuthorRepository;
        private readonly IMongoRepository<EmployerEntity> _employerRepository;


        public LibraryServiceController(IAuthorRepository authorRepository, IMongoRepository<AuthorEntity> genericAuthorRepository, IMongoRepository<EmployerEntity> employerRepository) {
            _authorRepository = authorRepository;
            _genericAuthorRepository = genericAuthorRepository;
            _employerRepository = employerRepository;
        }

        [HttpGet("genericEmployer")]
        public async Task<ActionResult<IEnumerable<EmployerEntity>>> GetEmployers()
        {
            var employers = await _employerRepository.GetAll();
            return Ok(employers);
        }

        [HttpGet("genericAuthor")]
        public async Task<ActionResult<IEnumerable<AuthorEntity>>> GetGenericAuthor()
        {
            var authors = await _genericAuthorRepository.GetAll();
            return Ok(authors);
        }

        [HttpGet("authors")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors() {
            var authors = await _authorRepository.GetAuthors();
            return Ok(authors);
        }

    }
}