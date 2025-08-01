namespace BlazorApp1.Components.Models

{
    public class Boats
    {
        public int Id { get; set; }                    // Clé primaire
        public string Nom { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;   // Exemple : Voilier, Yacht...
        public int Capacite { get; set; }              // Nombre maximal de personnes
        public decimal PrixParJour { get; set; }       // Tarif journalier

        public string? Description { get; set; }       // Description facultative
        public string? ImageUrl { get; set; }          // Image du bateau (facultatif)

        // Navigation : une liste de réservations pour ce bateau
        public List<Reservation> Reservations { get; set; } = new();
    }
}
