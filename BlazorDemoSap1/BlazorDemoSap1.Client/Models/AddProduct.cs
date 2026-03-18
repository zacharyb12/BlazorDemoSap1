using System.ComponentModel.DataAnnotations;

namespace BlazorDemoSap1.Client.Models
{
    public class AddProduct
    {
        [Required(ErrorMessage ="Le nom est requis")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Le champ description est requis")]
        [MaxLength(20,ErrorMessage ="La taille maximum est de 20 caractères")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Le prix est requis")]
        [Range(1,10000,ErrorMessage ="Le prix doit etre entre 1 et 10000")]
        public double Price { get; set; }

    }
}
