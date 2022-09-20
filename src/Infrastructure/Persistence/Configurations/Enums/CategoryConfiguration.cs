using Cherpumple.Domain.Entities;
using Cherpumple.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations.Enums;

public class CategoryConfiguration : IEntityTypeConfiguration<CategoryOptions>
{
    public void Configure(EntityTypeBuilder<CategoryOptions> builder)
    {
        builder.Property(e => e.Category).HasFlagToIntConversion();
    }
}