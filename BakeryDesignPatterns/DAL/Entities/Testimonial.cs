using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BakeryDesignPatterns.DAL.Entities
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string TestimonialName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }

    }
}
