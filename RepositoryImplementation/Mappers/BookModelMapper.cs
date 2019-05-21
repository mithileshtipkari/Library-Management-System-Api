using System.Collections.Generic;
using AutoMapper;
using DataAccess.Entity_Model;
using DomainModel;

namespace RepositoryImplementation.Mappers
{
    public static class BookModelMapper
    {
        public static List<BookItem> GetBookDomainModels(List<BookItemEntityModel> bookItemEntityModels)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(config =>
                    config.CreateMap<BookItemEntityModel, BookItem>()
                );

            IMapper mapper = mapperConfiguration.CreateMapper();
            return mapper.Map<List<BookItemEntityModel>, List<BookItem>>(bookItemEntityModels);
        }

        public static BookItem GetBookDomainModel(BookItemEntityModel bookItemEntityModel)
        {
            var bookItemDomainModel = new BookItem(bookItemEntityModel.Barcode,
                                                   bookItemEntityModel.IsReferenceOnly,
                                                   bookItemEntityModel.Borrowed,
                                                   bookItemEntityModel.DueDate,
                                                   bookItemEntityModel.Price,
                                                   bookItemEntityModel.Format,
                                                   bookItemEntityModel.Status,
                                                   bookItemEntityModel.DateOfPurchase,
                                                   bookItemEntityModel.PublicationDate,
                                                   bookItemEntityModel.PlacedAt,
                                                   bookItemEntityModel.ISBN,
                                                   bookItemEntityModel.Title,
                                                   bookItemEntityModel.Subject,
                                                   bookItemEntityModel.Publisher,
                                                   bookItemEntityModel.Language,
                                                   bookItemEntityModel.NoOfPages,
                                                   bookItemEntityModel.Authors);          
        }

        public static BookItemEntityModel GetBookItemEntityModel(BookItem bookItem)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(config =>
                config.CreateMap<BookItem, BookItemEntityModel>()
            );

            IMapper mapper = mapperConfiguration.CreateMapper();
            return mapper.Map<BookItem, BookItemEntityModel>(bookItem);
        }
    }
}