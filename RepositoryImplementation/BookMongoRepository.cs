using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entity_Model;
using DomainModel;
using UseCaseBoundary;
using MongoDB.Driver;
using DataAccess;

namespace RepositoryImplementation
{
    public class BookMongoRepository : BookRepository
    {
        private readonly LibraryManagementDBContext _libraryManagementDBContext = null;
        public BookMongoRepository()
        {
            _libraryManagementDBContext = LibraryManagementDBContext.Instance;
        }
        public Task<List<BookItem>> GetAllBookItem()
        {
            //IMongoCollection<BookItemEntityModel> BookEntityModels = _libraryManagementDBContext.Books;
            throw new NotImplementedException();

        }

        public Task<BookItem> GetBookItem(string title)
        {
            throw new NotImplementedException();
        }

        public Task<long> AddBookItem(BookItem bookItem)
        {
            throw new NotImplementedException();
        }
    }
}
