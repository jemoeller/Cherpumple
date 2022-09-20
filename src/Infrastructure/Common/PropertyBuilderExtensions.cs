using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cherpumple.Infrastructure.Common;

public static class PropertyBuilderExtensions
{
    public static PropertyBuilder<T> HasFlagToIntConversion<T>(this PropertyBuilder<T> builder) where T: struct
    {
        return builder.HasConversion(new EnumToNumberConverter<T, int>());
    }
}