using Cherpumple.Domain.Enums;
using Cherpumple.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations.Enums;

public class RecipeTagConfiguration : IEntityTypeConfiguration<RecipeTagOptions>
{
    public void Configure(EntityTypeBuilder<RecipeTagOptions> builder)
    {
        builder.Property(e => e.RecipeTag).HasFlagToIntConversion();
    }
}