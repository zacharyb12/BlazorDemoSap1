using BlazorDemoSap1.Client.Models;

namespace BlazorDemoSap1.Client.Pages
{
    public partial class Binding
    {
        // liste pour l'affichage dans la page
        public List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Apple iPhone 14 Pro Max",
                Description = "The iPhone 14 Pro Max is the latest flagship smartphone from Apple, featuring a stunning design, powerful performance, and advanced camera capabilities. With its large display, long battery life, and cutting-edge technology, the iPhone 14 Pro Max offers an exceptional user experience for those seeking the best in mobile technology.",
                Category = "Smartphones",
                Price = 1099.99,
                Quantity = 0
            },
            new Product
            {
                Id = 2,
                Name = "Samsung Galaxy S23 Ultra",
                Description = "The Samsung Galaxy S23 Ultra is a high-end smartphone that combines sleek design with powerful performance. It features a large, vibrant display, advanced camera system, and long-lasting battery life. With its cutting-edge technology and innovative features, the Galaxy S23 Ultra offers an exceptional user experience for those seeking the best in mobile technology.",
                Category = "Smartphones",
                Price = 1199.99,
                Quantity = 50
            },
            new Product
            {
                Id = 3,
                Name = "Google Pixel 7 Pro",
                Description = "The Google Pixel 7 Pro is a premium smartphone that offers a sleek design, powerful performance, and advanced camera capabilities. With its large display, long battery life, and cutting-edge technology, the Pixel 7 Pro provides an exceptional user experience for those seeking the best in mobile technology.",
                Category = "Smartphones",
                Price = 899.99,
                Quantity = 100
            }
        };

        // instance unique pour l'affichage dans la page
        public Product? product { get; set; } = new()
        {
            Id = 1,
            Name = "product 1",
            Description = "description product 1",
            Quantity = 10,
            Category = "Shoes",
            Price = 175.99
        };

        #region Binding two way lors d' un evenement
        // Declaration de deux variables une pour recuperation une pour affichage
        public string messageTwoWay { get; set; } = "hello world";
        public string messageAfterInput { get; set; }

        // methode qui permet de recupéré la valeur de l'input pour l'envoyer dans une autre variable
        public void GetMessage()
        {
            messageAfterInput = messageTwoWay;
        }
        #endregion

        #region 

        public List<string> valueSelect { get; set; } = new()
        {
            "un",
            "deux",
            "trois"
        };
        public string  message1 { get; set; }
        public void GetMessage(string value)
        {
            message1 = value;
        }


        #endregion

        #region mini login
        public string Email { get; set; }
        public string Password { get; set; }

        public string ResultLogin { get; set; }

        public void Login()
        {
            ResultLogin = $" {Email} - {Password}";
        }
        #endregion

        #region Exemple de binding
        public List<string> values { get; set; } = new()
        {
            "value 11",
            "value 12",
            "value 13",
            "value 14",
        };

        public List<string> resultFilter { get; set; } = new();

        public string search { get; set; }

        public void Filter(string value)
        {
            resultFilter = values.Where(s => s.Contains(value)).ToList();
        }
        #endregion

        #region Communication parent enfant

        // Valeur envoyé à l'enfant
        public string valueParent{ get; set; }

        // valeur reçu de l'enfant pour affichage
        public string valueFromChild { get; set; }


        // Methode pour recuperer la valeur de l'enfant
        public void UpdateValueParent(string valueForUpdate)
        {
            valueFromChild = valueForUpdate;
        }



        #endregion
    }
}
