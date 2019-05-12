using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entity_Model;
using DomainModel;
using UseCaseBoundary;
using MongoDB.Driver;
using DataAccess;
using MongoDB.Bson;
using RepositoryImplementation.Mappers;
using System.Linq;
using MongoDB.Driver.Linq;

namespace RepositoryImplementation
{
    public class BookMongoRepository : BookRepository
    {
        private readonly LibraryManagementDBContext _libraryManagementDBContext = null;
        public BookMongoRepository()
        {
            _libraryManagementDBContext = LibraryManagementDBContext.Instance;
        }
        public List<BookItem> GetAllBookItem()
        {
            List<BookItemEntityModel> bookItemEntityModels = _libraryManagementDBContext.Books.AsQueryable().ToList();
            List<BookItem> bookDomainModels = BookModelMapper.GetBookDomainModels(bookItemEntityModels);
            return bookDomainModels;
        }

        public BookItem GetBookItem(string title)
        {
            BookItemEntityModel bookItemEntityModel = _libraryManagementDBContext.Books.AsQueryable()
                .FirstOrDefault(x => x.title == title);
            BookItem bookDomainModel = BookModelMapper.GetBookDomainModel(bookItemEntityModel);
            return bookDomainModel;
        }

        public long AddBookItem(BookItem bookItem)
        {
            throw new NotImplementedException();
        }
    }
}
