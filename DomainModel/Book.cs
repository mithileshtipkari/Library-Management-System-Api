using System.Collections.Generic;
using DomainModel.Enums;

namespace DomainModel
{
    public abstract class Book
    {
        private readonly string _ISBN;
        private readonly string _title;
        private readonly string _subject;
        private readonly string _publisher;
        private readonly Language _language;
        private readonly int _noOfPages;
        private readonly List<string> _authors;

        protected Book(string ISBN, string title, string subject, string publisher, Language language, int noOfPages, List<string> authors)
        {
            _ISBN = ISBN;
            _title = title;
            _subject = subject;
            _publisher = publisher;
            _language = language;
            _noOfPages = noOfPages;
            _authors = authors;
        }


        public string GetTitle()
        {
            return _title;
        }
    }

}
