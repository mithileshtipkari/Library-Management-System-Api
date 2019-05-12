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
        public ObjectId objectId { get; set; }

        [Required]
        public string ISBN { get; set; }

        public string title { get; set; }

        public string subject { get; set; }

        public string publisher { get; set; }

        public string language { get; set; }

        public int noOfPages { get; set; }

        public List<string> authors { get; set; }

        public string barcode { get; set; }

        public bool isReferenceOnly { get; set; }

        [BsonDateTimeOptions]
        public DateTime borrowed { get; set; }

        [BsonDateTimeOptions]
        public DateTime dueDate { get; set; }

        public double price { get; set; }

        public string format { get; set; }

        public string status { get; set; }

        [BsonDateTimeOptions]
        public DateTime dateOfPurchase { get; set; }

        [BsonDateTimeOptions]
        public DateTime publicationDate { get; set; }

        public string placedAt { get; set; }

    }
}