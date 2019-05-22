using System;
using System.Collections.Generic;
using DomainModel.Enums;

namespace DomainModel
{
    public class BookItem : Book
    {
        private readonly string _barcode;
        private readonly bool _isReferenceOnly;
        private readonly DateTime _borrowed;
        private readonly DateTime _dueDate;
        private readonly double _price;
        private readonly BookFormat _format;
        private readonly BookStatus _status;
        private readonly DateTime _dateOfPurchase;
        private readonly DateTime _publicationDate;
        private readonly int _placedAt;

        public BookItem(string barcode, bool isReferenceOnly, DateTime borrowed, 
            DateTime dueDate, double price, BookFormat format, BookStatus status,
            DateTime dateOfPurchase, DateTime publicationDate, int placedAt,
            string ISBN, string title, string subject, string publisher, 
            Language language, int noOfPages, List<string> authors) : base(ISBN,
            title , subject, publisher, language, noOfPages, authors)
        {
            _barcode = barcode;
            _isReferenceOnly = isReferenceOnly;
            _borrowed = borrowed;
            _dueDate = dueDate;
            _price = price;
            _format = format;
            _status = status;
            _dateOfPurchase = dateOfPurchase;
            _publicationDate = publicationDate;
            _placedAt = placedAt;
        }

        //method business logic needs to be added later
        public bool ckeckout(string memberId)
        {
            return true;
        }
    }

}