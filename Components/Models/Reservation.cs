using BlazorApp1.Components.Data;

namespace BlazorApp1.Components.Models
{
    public class Reservation
    {
        public int Id { get; set; }                      // Identifiant unique
        public int BateauId { get; set; }                // Clé étrangère vers Bateau
        public int UtilisateurId { get; set; }           // Clé étrangère vers Utilisateur

        public DateTime DateDebut { get; set; }          // Date de début de la réservation
        public DateTime DateFin { get; set; }            // Date de fin

        public decimal PrixTotal { get; set; }           // Coût total de la réservation
        public bool EstValidee { get; set; }             // Statut de validation

        // Propriétés de navigation (EF Core)
        public Boats? Bateau { get; set; }
        public User? Utilisateur { get; set; }
    }
}
