using Cherpumple.Domain.Enums;
using Cherpumple.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations.Enums;

public class RegionConfiguration : IEntityTypeConfiguration<RegionOptions>
{
    public void Configure(EntityTypeBuilder<RegionOptions> builder)
    {
        builder.Property(e => e.Region).HasFlagToIntConversion();
    }
}