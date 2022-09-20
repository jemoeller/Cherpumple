using System.ComponentModel.DataAnnotations;

namespace Cherpumple.Domain.Enums;

[Flags]
public enum RecipeTags
{
    None = 0,
    ClimateFriendly = 1 << 0,
    Inspiration = 1 << 1,
    Economical = 1 << 2,
    Fancy = 1 << 3,
    Impressive = 1 << 4,
    NoWaste = 1 << 5,
}