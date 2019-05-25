using DomainModel;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System.Collections.Generic;
using UseCaseBoundary;

namespace LibraryManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepository _bookRepository;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<BookItem> GetAllBooks()
        {
            return _bookRepository.GetAllBookItem();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public BookItem GetBook(string title)
        {
            return _bookRepository.GetBookItem(title);
        }

        // POST api/values
        [HttpPost]
        public ObjectId Post([FromBody] BookItem bookItem)
        {
           return _bookRepository.AddBookItem(bookItem);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
