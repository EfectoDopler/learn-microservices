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
    public class BookServiceController : ControllerBase
    {
        private readonly IMongoRepository<BookEntity> _bookRepository;

        public BookServiceController(IMongoRepository<BookEntity> bookRepository) {
            _bookRepository = bookRepository;
        }

        [HttpPost]
        public async Task Post(BookEntity book) {
           await _bookRepository.InsertDocument(book);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookEntity>>> GetAll() {
            var books = await _bookRepository.GetAll();
            return Ok(books);
        }

        [HttpPost("getById")]
        public async Task<ActionResult<BookEntity>> GetById(string id) {
            var book = await _bookRepository.GetById(id);
            return Ok(book);
        }

        [HttpGet("pagination")]
        public async Task<ActionResult<PaginatorEntity<BookEntity>>> PostPagination(PaginatorEntity<BookEntity> pagination) {
            var results = await _bookRepository.PaginationByFilter(pagination);
            return Ok(results);
        }

    }
}