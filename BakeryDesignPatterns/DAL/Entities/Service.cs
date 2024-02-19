using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BakeryDesignPatterns.DAL.Entities
{
    public class Service
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
    }
}
