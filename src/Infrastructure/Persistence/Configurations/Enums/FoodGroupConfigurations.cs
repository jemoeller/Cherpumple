using Cherpumple.Domain.Enums;
using Cherpumple.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cherpumple.Infrastructure.Persistence.Configurations.Enums;

public class FoodGroupConfigurations : IEntityTypeConfiguration<FoodGroupOptions>
{
    public void Configure(EntityTypeBuilder<FoodGroupOptions> builder)
    {
        builder.Property(e => e.FoodGroup).HasFlagToIntConversion();
    }
}


