using Cherpumple.Domain.Enums;
using Cherpumple.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations.Enums;

public class DifficultyConfiguration : IEntityTypeConfiguration<DifficultyLevelOptions>
{
    public void Configure(EntityTypeBuilder<DifficultyLevelOptions> builder)
    {
        builder.Property(e => e.DifficultyLevel).HasConversion<int>();
    }
}