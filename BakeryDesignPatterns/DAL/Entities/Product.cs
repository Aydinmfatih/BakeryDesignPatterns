using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BakeryDesignPatterns.DAL.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }


    }
}
