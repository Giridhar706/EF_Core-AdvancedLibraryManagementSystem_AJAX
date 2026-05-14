using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;
using AdvancedLibraryManagementSystem.Repositories;

namespace AdvancedLibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseBooksController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        private readonly BookRepository _repository;

        public DatabaseBooksController(
            LibraryDbContext context,
            BookRepository repository)
        {
            _context = context;

            _repository = repository;
        }

        // GET: api/DatabaseBooks
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books =
                await _repository.GetAll();

            return Ok(books);
        }

        // GET: api/DatabaseBooks/OptimizedBooks
        [HttpGet("OptimizedBooks")]
        public async Task<IActionResult> OptimizedBooks()
        {
            var books = await _context.Books
                .Include(b => b.Author)
                .OrderBy(b => b.Title)
                .ToListAsync();

            return Ok(books);
        }

        // POST: api/DatabaseBooks
        [HttpPost]
        public async Task<IActionResult> PostBook(Book book)
        {
            try
            {
                await _repository.Add(book);

                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/DatabaseBooks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(
            int id,
            Book book)
        {
            if (id != book.BookId)
            {
                return BadRequest();
            }

            try
            {
                await _repository.Update(book);

                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/DatabaseBooks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                await _repository.Delete(id);

                return Ok("Book Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}