namespace Cherpumple.Domain.Enums;


// to combine enumerations, use the bitwise "|" operator. To check whether an enum exists in a flag, use the bitwise "&" operator. Likewise, we can use the HasFlag method. 
[Flags]
public enum FoodGroup
{
    None = 0, 
    Spice = 1 << 0,
    Vegetable = 2 << 1,
    Meat = 3 << 2,
    Carbohydrates = 4 << 3
}

public class FoodGroupOptions : BaseEntity
{
    public string Name { get; set; }
    public FoodGroup FoodGroup { get; set; }
}