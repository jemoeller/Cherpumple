using Cherpumple.Domain.Enums;
using Cherpumple.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations.Enums;

public class MeasurementUnitConfiguration : IEntityTypeConfiguration<MeasurementUnitOptions>
{
    public void Configure(EntityTypeBuilder<MeasurementUnitOptions> builder)
    {
        builder.Property(e => e.MeasurementUnit).HasFlagToIntConversion();
    }
}