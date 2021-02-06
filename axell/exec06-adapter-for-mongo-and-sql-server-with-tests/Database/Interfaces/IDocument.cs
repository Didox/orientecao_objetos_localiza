using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NetCoreApi.Database.Interfaces
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }
    }
}
