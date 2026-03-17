using BlazorDemoSap1.Client.Models;

namespace BlazorDemoSap1.Client.Pages
{
    public partial class Binding
    {
        public List<Product> products = new()
        {
            new Product
            {
                Id = Guid.Parse("23a29494-d1aa-42fd-9a9a-cfc1ff55a550"),
                Name = "Apple iPhone 14 Pro Max",
                Description = "The iPhone 14 Pro Max is the latest flagship smartphone from Apple, featuring a stunning design, powerful performance, and advanced camera capabilities. With its large display, long battery life, and cutting-edge technology, the iPhone 14 Pro Max offers an exceptional user experience for those seeking the best in mobile technology.",
                Category = "Smartphones",
                Price = 1099.99,
                Quantity = 0
            },
            new Product
            {
                Id = Guid.Parse("5734969e-5048-47db-bb35-a5a785e71fea"),
                Name = "Samsung Galaxy S23 Ultra",
                Description = "The Samsung Galaxy S23 Ultra is a high-end smartphone that combines sleek design with powerful performance. It features a large, vibrant display, advanced camera system, and long-lasting battery life. With its cutting-edge technology and innovative features, the Galaxy S23 Ultra offers an exceptional user experience for those seeking the best in mobile technology.",
                Category = "Smartphones",
                Price = 1199.99,
                Quantity = 50
            },
            new Product
            {
                Id = Guid.Parse("43c5559e-2ef2-4fa9-b608-f5fa4f9862d2"),
                Name = "Google Pixel 7 Pro",
                Description = "The Google Pixel 7 Pro is a premium smartphone that offers a sleek design, powerful performance, and advanced camera capabilities. With its large display, long battery life, and cutting-edge technology, the Pixel 7 Pro provides an exceptional user experience for those seeking the best in mobile technology.",
                Category = "Smartphones",
                Price = 899.99,
                Quantity = 100
            }
        };


    }
}
