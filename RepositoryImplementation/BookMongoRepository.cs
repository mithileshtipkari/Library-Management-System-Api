using DataAccess;
using DataAccess.Entity_Model;
using DomainModel;
using MongoDB.Driver;
using RepositoryImplementation.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCaseBoundary;

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
                .FirstOrDefault(x => x.Title == title);
            BookItem bookDomainModel = BookModelMapper.GetBookDomainModel(bookItemEntityModel);
            return bookDomainModel;
        }

        public void AddBookItem(BookItem bookItem)
        {
            BookItemEntityModel bookItemEntityModel = BookModelMapper.GetBookItemEntityModel(bookItem);
            _libraryManagementDBContext.Books.InsertOne(bookItemEntityModel);
        }
    }
}
