namespace BlazorDemoSap1.Models.RecipeModels
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Recette { get; set; }

        public string Ingredients { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
