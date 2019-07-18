using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongonetcore
{
    /// <summary>
    /// Class used in business logic to represent user.
    /// </summary>
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("blog")]
        public string Blog { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
        [BsonElement("location")]
        public string Location { get; set; }
    }
}
