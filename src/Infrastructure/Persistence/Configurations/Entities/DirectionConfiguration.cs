using Cherpumple.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations;

public class DirectionConfiguration : IEntityTypeConfiguration<Direction>
{
    public void Configure(EntityTypeBuilder<Direction> builder)
    {
        builder
            .HasOne(x => x.Recipe)
            .WithMany(r => r.Directions);

        builder.Property(d => d.RecipeId).IsRequired();
        builder.Property(d => d.Step).IsRequired();
        builder.Property(d => d.Description).IsRequired();


    }
}