namespace Cherpumple.Domain.Entities;

public class Image
{
    public int Order { get; set; }
    
    public string ImageUrl { get; set; }
    
    // dependent on recipe entity.
    public Recipe Recipe { get; set; }
    
    public int RecipeId { get; set; }
}