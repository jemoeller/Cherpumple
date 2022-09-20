namespace Cherpumple.Domain.Entities;

[Flags]
public enum Category
{
    Breakfast,
    Dinner,
    Lunch,
    Brunch,
    Appetizer,
    Desert,
    Cake,
}

public class CategoryOptions : BaseEntity
{
    public string Name { get; set; }
    
    public Category Category { get; set; }
}