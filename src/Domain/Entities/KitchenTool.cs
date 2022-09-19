namespace Cherpumple.Domain.Entities;

public class KitchenTool : BaseEntity
{
    public string Name { get; set; }
    
    public Recipe Recipe { get; set; }
    
    public int RecipeId { get; set; }
}