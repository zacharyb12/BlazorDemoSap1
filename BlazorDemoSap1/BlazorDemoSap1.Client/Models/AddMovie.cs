using System.ComponentModel.DataAnnotations;

namespace BlazorDemoSap1.Client.Models
{
    public class AddMovie
    {
        [Required(ErrorMessage = "Le titre est requis.")]
        [MaxLength(50, ErrorMessage = " La taille du titre ne peut pas dépasser 50 caractères")]
        public string Titre { get; set; }


        [Required(ErrorMessage = "La description est requise.")]
        [MaxLength(200, ErrorMessage = " La taille de la description ne peut pas dépasser 200 caractères")]
        public string Description { get; set; }


        [Required(ErrorMessage = "L'année de production est requise.")]
        [Range(1850,2026, ErrorMessage = " L'année de production doit être entre 1850 et 2026")]
        public int AnneeDeProd { get; set; }


        [Required(ErrorMessage ="Le nom du réalisateur est requis")]
        [MaxLength(50, ErrorMessage = " La taille du nom du réalisateur ne peut pas dépasser 50 caractères")]
        public string Realisateur { get; set; }
    }
}
