using BlazorDemoSap1.Models.RecipeModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDemoSap1.Data.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("Recipe");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(255);


            builder.Property(r => r.Description)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(r => r.Recette)
                    .IsRequired();

            builder.Property(r => r.Ingredients)
                    .IsRequired();

            builder.Property(r => r.CreatedAt)
                    .IsRequired()
                    .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
