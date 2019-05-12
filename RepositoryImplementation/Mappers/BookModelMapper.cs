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
            MapperConfiguration mapperConfiguration = new MapperConfiguration(config =>
                config.CreateMap<BookItemEntityModel, BookItem>()
                );

            IMapper mapper = mapperConfiguration.CreateMapper();
            return mapper.Map<BookItemEntityModel, BookItem>(bookItemEntityModel);
        }
    }
}