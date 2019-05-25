using DomainModel;
using MongoDB.Bson;
using System.Collections.Generic;

namespace UseCaseBoundary
{
    public interface BookRepository
    {
        IEnumerable<BookItem> GetAllBookItem();

        BookItem GetBookItem(string title);

        ObjectId AddBookItem(BookItem bookItem);
    }
}
