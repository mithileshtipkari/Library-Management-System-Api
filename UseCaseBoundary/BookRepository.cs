using DomainModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace UseCaseBoundary
{
    public interface BookRepository
    {
        List<BookItem> GetAllBookItem();

        BookItem GetBookItem(string title);

        ObjectId AddBookItem(BookItem bookItem);
    }
}
