using BlazorDemoSap1.Models.RecipeModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemoSap1.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base (options)
        {
            
        }

        public DbSet<Recipe> Recipes {  get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly( typeof(DemoContext).Assembly );
        }
    }
}
