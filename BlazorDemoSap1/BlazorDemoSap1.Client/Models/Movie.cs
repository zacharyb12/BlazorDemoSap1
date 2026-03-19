using System.Security.Cryptography;

namespace BlazorDemoSap1.Client.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string  Description{ get; set; }
        public int  AnneeDeProd { get; set; }
        public string Realisateur { get; set; }
    }
}
