using Cherpumple.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations;

public class KitchenToolsConfiguration : IEntityTypeConfiguration<KitchenTool>
{
    public void Configure(EntityTypeBuilder<KitchenTool> builder)
    {

        builder.Property(kt => kt.Name).IsRequired();
        builder.Property(kt => kt.RecipeId).IsRequired();
    }
}