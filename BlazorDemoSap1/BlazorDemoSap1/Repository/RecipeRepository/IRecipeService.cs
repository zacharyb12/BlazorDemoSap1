using BlazorDemoSap1.Models.RecipeModels;

namespace BlazorDemoSap1.Repository.RecipeRepository
{
    public interface IRecipeService
    {
        Task<List<Recipe>> GetAll();

        Task<Recipe?> GetById(int id);

        Task<bool> CreateRecipe(AddRecipe newRecipe);

        Task<bool> DeleteRecipe(int id);

        Task<bool> UpdateRecipe(UpdateRecipe updatedRecipe, int id);
    }
}
