using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Components.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}