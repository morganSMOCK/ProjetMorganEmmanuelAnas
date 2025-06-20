using MongoDB.Driver;
using MongoDB.Bson;
using BlazorApp1.Components.Data; // Assure-toi d'importer le modèle Utilisateur

namespace BlazorApp1.Services
{
    public class MongoDBService
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Utilisateur> _utilisateursCollection;

        public MongoDBService()
        {
            // Connexion à MongoDB Atlas via l'URI de connexion
            const string connectionUri = "mongodb+srv://Morgan:<m27S78K973!?1234>@cluster0.vb5hlem.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

            // Paramètres de connexion
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1); // Version de l'API MongoDB

            _client = new MongoClient(settings);
            _database = _client.GetDatabase("SaillingBoat"); // Connecte à la base de données 'admin' pour tester la connexion

            // Initialisation de la collection des utilisateurs
            _utilisateursCollection = _database.GetCollection<Utilisateur>("utilisateurs");
        }

        // Méthode pour tester la connexion
        public async Task TestConnectionAsync()
        {
            try
            {
                var result = await _database.RunCommandAsync<BsonDocument>(new BsonDocument("ping", 1));
                Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Méthode pour ajouter un utilisateur
        public async Task AddUtilisateurAsync(Utilisateur utilisateur)
        {
            try
            {
                // Insertion de l'utilisateur dans la collection MongoDB
                await _utilisateursCollection.InsertOneAsync(utilisateur);
                Console.WriteLine("Utilisateur ajouté avec succès !");
            }
            catch (Exception ex)
            {
                // Gère les erreurs en cas d'échec
                throw new Exception($"Erreur lors de l'ajout de l'utilisateur : {ex.Message}");
            }
        }

        // Méthode pour récupérer tous les utilisateurs
        public async Task<List<Utilisateur>> GetAllAsync()
        {
            try
            {
                // Récupérer tous les utilisateurs de la collection MongoDB
                return await _utilisateursCollection.Find(new BsonDocument()).ToListAsync();
            }
            catch (Exception ex)
            {
                // Gérer les erreurs en cas de problème
                throw new Exception($"Erreur lors de la récupération des utilisateurs : {ex.Message}");
            }
        }
    }
}
