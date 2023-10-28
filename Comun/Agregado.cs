using MongoDB.Bson.Serialization.Attributes;

namespace Comun
{
    // All the code in this file is included in all platforms.
    public  abstract class Agregado
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }

    }
}