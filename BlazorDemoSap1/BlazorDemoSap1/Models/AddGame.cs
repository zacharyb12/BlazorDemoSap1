using System.ComponentModel.DataAnnotations;

namespace BlazorDemoSap1.Models
{
    public class AddGame
    {
        [Required(ErrorMessage = "Le Createur est requis")]
        public string Creator { get; set; }

        [Required(ErrorMessage = "Le Nom est requis")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La Description est requise")]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public double Price { get; set; }
    }
}
