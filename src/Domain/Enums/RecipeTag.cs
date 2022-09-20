namespace Cherpumple.Domain.Enums;

[Flags]
public enum RecipeTag
{
    None = 0,
    ClimateFriendly = 1 << 0,
    Inspiration = 2 << 1,
    Economical = 3 << 2,
    Fancy = 4 << 3,
    Impressive = 5 << 4,
    NoWaste = 6 << 5,
}

public class RecipeTagOptions : BaseEntity
{
    public string Name { get; set; }
    public RecipeTag RecipeTag { get; set; }
}
