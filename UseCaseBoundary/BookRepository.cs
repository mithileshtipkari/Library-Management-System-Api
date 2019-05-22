using DomainModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UseCaseBoundary
{
    public interface BookRepository
    {
        List<BookItem> GetAllBookItem();

        BookItem GetBookItem(string title);

        void AddBookItem(BookItem bookItem);
    }
}
