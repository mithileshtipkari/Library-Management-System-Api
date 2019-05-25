using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity_Model
{
    [BsonIgnoreExtraElements]
    public class BookItemEntityModel
    {
        [BsonId]
        public ObjectId objectId { get; set; }

        [Required]
        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Subject { get; set; }

        public string Publisher { get; set; }

        public string Language { get; set; }

        public int NoOfPages { get; set; }

        public List<string> Authors { get; set; }

        public string Barcode { get; set; }

        public bool IsReferenceOnly { get; set; }

        [BsonDateTimeOptions]
        public DateTime Borrowed { get; set; }

        [BsonDateTimeOptions]
        public DateTime DueDate { get; set; }

        public double Price { get; set; }

        public string Format { get; set; }

        public string Status { get; set; }

        [BsonDateTimeOptions]
        public DateTime DateOfPurchase { get; set; }

        [BsonDateTimeOptions]
        public DateTime PublicationDate { get; set; }

        public int PlacedAt { get; set; }

    }
}