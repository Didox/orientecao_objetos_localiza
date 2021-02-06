using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NetCoreApi.Database.Interfaces;

namespace NetCoreApi.Database.Models
{
    public class WeatherForecast : IDocument
    {
        private ObjectId _id;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId IDocument.Id
        {
            get => _id;
            set => _id = value;
        }
    }
}
