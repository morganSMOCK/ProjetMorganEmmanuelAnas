using BlazorApp1.Components.Models;

namespace BlazorApp1.Components.Pages
{

    public class Boat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public decimal PrixParJour { get; set; }
        public int Capacite { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }


    public partial class BoatList
    {
        private List<Boat> Boats = new()
        {
            new Boat { Id = 1, Nom = "Le Corsaire", PrixParJour = 250, Capacite = 6, ImageUrl = "img/corsaire.jpg", Description = "Bateau au style classique et robuste, parfait pour une sortie pleine de charme et de caractère sur les flots." },
            new Boat { Id = 2, Nom = "La Sirène", PrixParJour = 300, Capacite = 8, ImageUrl = "img/sirene.jpg", Description = "Élégant et raffiné, idéal pour une balade romantique ou une journée paisible en bord de mer." },
            new Boat { Id = 3, Nom = "L'Aqua Nova", PrixParJour = 200, Capacite = 6, ImageUrl = "img/corsaire.jpg", Description = "Design moderne et moteur performant, pour allier vitesse et confort lors de vos aventures nautiques." },
            new Boat { Id = 4, Nom = "Evasion Bleu", PrixParJour = 230, Capacite = 8, ImageUrl = "img/sirene.jpg", Description = "Un cocon flottant pour s’évader du quotidien, avec un espace généreux pour profiter du soleil et de la mer.\r\n\r\n" },
            new Boat { Id = 5, Nom = "Le Coral Dream", PrixParJour = 250, Capacite = 6, ImageUrl = "img/corsaire.jpg", Description = "Pensé pour la détente, avec assises confortables et coin repas à bord. Parfait pour un pique-nique flottant au soleil." },
            new Boat { Id = 6, Nom = "Le Wave Dancer", PrixParJour = 380, Capacite = 7, ImageUrl = "img/sirene.jpg", Description = "Polyvalent et convivial, idéal pour explorer les criques cachées ou passer une journée de loisirs aquatiques." },
            new Boat { Id = 7, Nom = "The Sea Walker", PrixParJour = 270, Capacite = 6, ImageUrl = "img/corsaire.jpg", Description = "Bateau moderne et confortable, idéal pour une journée détente en famille ou entre amis. Spacieux et stable, il vous emmène voguer en toute tranquillité." },
            new Boat { Id = 8, Nom = "Blue Horizon", PrixParJour = 400, Capacite = 8, ImageUrl = "img/sirene.jpg", Description = "Parfait pour admirer les couchers de soleil, ce bateau élégant offre un pont généreux et un confort optimal pour vos escapades maritimes." },
            new Boat { Id = 9, Nom = "Ocean Breeze", PrixParJour = 180, Capacite = 5, ImageUrl = "img/corsaire.jpg", Description = "Rapide et maniable, ce bateau est parfait pour alterner moments de baignade et navigation le long des côtes." },
            new Boat { Id = 10, Nom = "Sunset Spirit", PrixParJour = 210, Capacite = 6, ImageUrl = "img/sirene.jpg", Description = "Un choix idéal pour les fêtes en mer : système audio intégré, espace pour danser et vue imprenable sur l’horizon." }
        };
    }
}