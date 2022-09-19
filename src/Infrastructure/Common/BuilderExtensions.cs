using Cherpumple.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Common;

public static class BuilderExtensions
{
    // public static void CreateEnumValues<TRef, TEnum>(this EntityTypeBuilder<TRef> builder)
    //     where TRef : class, BaseEnum<TEnum, TRef>, new()
    //     where TEnum : Enum
    //
    // {
    //     var type = 
    //     builder.HasData(Enum.GetValues(typeof(TRef))
    //         .Cast<TEnum>()
    //         .Select(e => new TRef() { Name = e.ToString(), Enum = e }));
    // }
}