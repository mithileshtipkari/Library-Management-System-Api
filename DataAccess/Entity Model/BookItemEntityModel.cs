using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace DataAccess.Entity_Model
{
    [BsonIgnoreExtraElements]
    public class BookItemEntityModel
    {
        [BsonId]
        public ObjectId _objectId { get; set; }

        [Required]
        public string _ISBN { get; set; }

        public string _title { get; set; }

        public string _subject { get; set; }

        public string _publisher { get; set; }

        public string _language { get; set; }

        public int _noOfPages { get; set; }

        public List<string> _authors { get; set; }

        public string _barcode { get; set; }

        public bool _isReferenceOnly { get; set; }

        [BsonDateTimeOptions]
        public DateTime _borrowed { get; set; }

        [BsonDateTimeOptions]
        public DateTime _dueDate { get; set; }

        public double _price { get; set; }

        public string _format { get; set; }

        public string _status { get; set; }

        [BsonDateTimeOptions]
        public DateTime _dateOfPurchase { get; set; }

        [BsonDateTimeOptions]
        public DateTime _publicationDate { get; set; }

        public string _placedAt { get; set; }

    }
}