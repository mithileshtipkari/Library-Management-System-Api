using DataAccess;
using DataAccess.Entity_Model;
using DomainModel;
using MongoDB.Bson;
using MongoDB.Driver;
using RepositoryImplementation.Mappers;
using System.Collections.Generic;
using System.Linq;
using UseCaseBoundary;

namespace RepositoryImplementation
{
    public class BookMongoRepository : BookRepository
    {
        private readonly LibraryManagementDBContext _libraryManagementDbContext;

        public BookMongoRepository()
        {
            _libraryManagementDbContext = LibraryManagementDBContext.Instance;
        }

        public IEnumerable<BookItem> GetAllBookItem()
        {
            IEnumerable<BookItemEntityModel> bookItemEntityModels = _libraryManagementDbContext.Books.AsQueryable();
            IEnumerable<BookItem> bookDomainModels = BookModelMapper.GetBookDomainModels(bookItemEntityModels);
            return bookDomainModels;
        }

        public BookItem GetBookItem(string title)
        {
            BookItemEntityModel bookItemEntityModel = _libraryManagementDbContext.Books.AsQueryable()
                .FirstOrDefault(x => x.Title == title);
            BookItem bookDomainModel = BookModelMapper.GetBookDomainModel(bookItemEntityModel);
            return bookDomainModel;
        }

        public ObjectId AddBookItem(BookItem bookItem)
        {
            BookItemEntityModel bookItemEntityModel = BookModelMapper.GetBookItemEntityModel(bookItem);
            _libraryManagementDbContext.Books.InsertOne(bookItemEntityModel);

            ObjectId id = bookItemEntityModel.objectId;
            return id;
        }
    }
}
