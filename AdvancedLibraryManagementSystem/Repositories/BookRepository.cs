using LibraryManagementSystem.Models;

namespace AdvancedLibraryManagementSystem.Repositories
{
    public class BookRepository :
        GenericRepository<Book>
    {
        public BookRepository(
            LibraryDbContext context)
            : base(context)
        {
        }
    }
}