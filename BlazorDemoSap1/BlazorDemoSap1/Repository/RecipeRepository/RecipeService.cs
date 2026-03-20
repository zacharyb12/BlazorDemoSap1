using BlazorDemoSap1.Data;
using BlazorDemoSap1.Models.RecipeModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemoSap1.Repository.RecipeRepository
{
    public class RecipeService(DemoContext _context) : IRecipeService
    {
        public async Task<List<Recipe>> GetAll()
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<bool> CreateRecipe(AddRecipe newRecipe)
        {
            Recipe? recipe = await _context.Recipes.FirstOrDefaultAsync(r => 
            r.Name == newRecipe.Name
            &&
            r.Ingredients == newRecipe.Ingredients
            &&
            r.Recette == newRecipe.Recette
            );

            if(recipe != null)
            {
                return false;
            }

            Recipe recipeToAdd = new Recipe()
            {
                Name = newRecipe.Name,
                Description = newRecipe.Description,
                Recette = newRecipe.Recette,
                Ingredients = newRecipe.Ingredients,
                CreatedAt = DateTime.Now
            };

            await _context.Recipes.AddAsync( recipeToAdd );
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteRecipe(int id)
        {
            Recipe? recipeToDelete = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == id);

            if(recipeToDelete == null)
            {
                return false;
            }

            _context.Recipes.Remove(recipeToDelete);

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<Recipe?> GetById(int id)
        {
            Recipe? recipe = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == id);

            if (recipe == null)
            {
                return null;
            }
            return recipe;
        }

        public async Task<bool> UpdateRecipe(UpdateRecipe updatedRecipe,int id)
        {
            Recipe? recipeToUpdate = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == id);

            if (recipeToUpdate == null)
            {
                return false;
            }

            recipeToUpdate.Description = updatedRecipe.Description;
            recipeToUpdate.Recette = updatedRecipe.Recette;
            recipeToUpdate.Ingredients = updatedRecipe.Ingredients;

            await _context.SaveChangesAsync();

            return true;

        }
    }
}
