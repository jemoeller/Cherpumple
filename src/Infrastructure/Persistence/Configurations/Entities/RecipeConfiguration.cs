using Cherpumple.Domain.Entities;
using Cherpumple.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cherpumple.Infrastructure.Common;

namespace Cherpumple.Infrastructure.Persistence.Configurations;

public class RecipeConfiguration: IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        builder.HasOne(r => r.Author);
        builder.HasMany(r => r.Tools);
        builder.HasMany(r => r.Directions);

        // non-collection property
        builder.Property(r => r.AuthorId).IsRequired();
        builder.Property(r => r.DurationPreparation).IsRequired();
        builder.Property(r => r.DurationCooking).IsRequired();
        builder.Property(r => r.Title).IsRequired();
        builder.Property(r => r.Serves).IsRequired();
        builder.Property(r => r.DifficultyLevel).IsRequired();
        builder.Property(r => r.Description).IsRequired();
        
        //CONVERSIONS
        builder.Property(e => e.RecipeTags).HasFlagToIntConversion();
        builder.Property(e => e.Categories).HasFlagToIntConversion();

        // builder.Property(r => r.Tags).HasConversion(
        //     t => t.Select(e => e.ToString()),
        //     t => t.Select(e => (RecipeTags)Enum.Parse(typeof(RecipeTags), e)).ToList() ?? new List<RecipeTags>()
        //     );


        // collection properties
        // builder.Property(r => r.Directions).IsRequired();
    }
}