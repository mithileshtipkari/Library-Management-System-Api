using DomainModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCaseBoundary
{
    public interface BookRepository
    {
        Task<List<BookItem>> GetAllBookItem();

        Task<BookItem> GetBookItem(string title);

        Task<long> AddBookItem(BookItem bookItem);
    }
}
