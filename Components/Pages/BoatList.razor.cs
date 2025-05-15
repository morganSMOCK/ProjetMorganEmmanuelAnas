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
            new Boat { Id = 1, Nom = "Le Corsaire", PrixParJour = 250, Capacite = 6, ImageUrl = "img/corsaire.jpg", Description = "Un voilier rapide et élégant." },
            new Boat { Id = 2, Nom = "La Sirène", PrixParJour = 300, Capacite = 8, ImageUrl = "img/sirene.jpg", Description = "Parfait pour des excursions en famille." }
        };
    }
}