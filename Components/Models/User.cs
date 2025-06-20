using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorApp1.Components.Data
{
    public class Utilisateur
    {
        [BsonId]  // Le champ Id est l'identifiant unique dans MongoDB
        public ObjectId Id { get; set; }

        public string Nom { get; set; }
        public string Email { get; set; }
    }
}
