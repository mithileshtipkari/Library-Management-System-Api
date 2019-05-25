using System;
using System.Collections.Generic;
using AutoMapper;
using DataAccess.Entity_Model;
using DomainModel;
using DomainModel.Enums;

namespace RepositoryImplementation.Mappers
{
    public static class BookModelMapper
    {
        public static IEnumerable<BookItem> GetBookDomainModels(IEnumerable<BookItemEntityModel> bookItemEntityModels)
        {
            List<BookItem> bookItems = new List<BookItem>();

            foreach (BookItemEntityModel bookItemEntityModel in bookItemEntityModels)
            {
                BookItem bookItem = GetBookDomainModel(bookItemEntityModel);
                bookItems.Add(bookItem);
            }

            return bookItems;
        }

        public static BookItem GetBookDomainModel(BookItemEntityModel bookItemEntityModel)
        {
            var bookItemDomainModel = new BookItem(bookItemEntityModel.Barcode,
                                                   bookItemEntityModel.IsReferenceOnly,
                                                   bookItemEntityModel.Borrowed,
                                                   bookItemEntityModel.DueDate,
                                                   bookItemEntityModel.Price,
                                                   ConvertStringToEnumBookFormat(bookItemEntityModel.Format),
                                                   ConvertStringToEnumBookStatus(bookItemEntityModel.Status),
                                                   bookItemEntityModel.DateOfPurchase,
                                                   bookItemEntityModel.PublicationDate,
                                                   bookItemEntityModel.PlacedAt,
                                                   bookItemEntityModel.ISBN,
                                                   bookItemEntityModel.Title,
                                                   bookItemEntityModel.Subject,
                                                   bookItemEntityModel.Publisher,
                                                   ConvertStringToEnumLanguage(bookItemEntityModel.Language),
                                                   bookItemEntityModel.NoOfPages,
                                                   bookItemEntityModel.Authors);
            return bookItemDomainModel;
        }

        private static Language ConvertStringToEnumLanguage(string language)
        {
            switch (language)
            {
                case "Marathi":
                    return Language.Marathi;
                case "Hindi":
                    return Language.Hindi;
                case "English":
                    return Language.English;
                case "Urdu":
                    return Language.Urdu;
                case "Sanskrit":
                    return Language.Sanskrit;
            }

            return Language.Unknown;
        }

        private static BookStatus ConvertStringToEnumBookStatus(string status)
        {
            switch (status)
            {
                case "Available":
                    return BookStatus.Available;
                case "Reserved":
                    return BookStatus.Reserved;
                case "Loaned":
                    return BookStatus.Loaned;
                case "Lost":
                    return BookStatus.Lost;
            }

            return BookStatus.Unknown;
        }

        private static BookFormat ConvertStringToEnumBookFormat(string format)
        {
            switch (format)
            {
                case "Hardcover":
                    return BookFormat.Hardcover;
                case "Paperback":
                    return BookFormat.Paperback;
                case "AudioBook":
                    return BookFormat.AudioBook;
                case "Ebook":
                    return BookFormat.Ebook;
                case "Newspaper":
                    return BookFormat.Newspaper;
                case "Magazine":
                    return BookFormat.Magazine;
                case "Journal":
                    return BookFormat.Journal;
            }

            return BookFormat.Unknown;
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