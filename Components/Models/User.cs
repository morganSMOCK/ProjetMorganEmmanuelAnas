using BlazorApp1.Components.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Components.Data
{
    public class User
    {
        public int Id { get; set; }                      // Clé primaire
        public string Nom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string? Telephone { get; set; }
        public string? MotDePasse { get; set; }           // A gérer avec prudence (hashé côté sécurité)

        public bool EstAdmin { get; set; } = false;       // Si l’utilisateur est admin ou non

        // Navigation : réservations faites par l'utilisateur
        public List<Reservation> Reservations { get; set; } = new();
    }
}