using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BakeryDesignPatterns.DAL.Entities
{
    public class Client
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }


    }
}
