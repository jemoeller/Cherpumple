namespace Cherpumple.Domain.Entities;

public class Recipe : BaseAuditableEntity
{
    // required non-collection properties
    public Author Author { get; set; }
    public int AuthorId { get; set; }
    public string DurationPreparation { get; set; }
    public string DurationCooking { get; set; }
    public string Title { get; set; }
    public int Serves { get; set; }
    public string Description { get; set; }
    
    // optional non-collection properties
    public string Notes { get; set; }
    
    // Required collection properties
    public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public ICollection<Direction> Directions { get; set; } = new List<Direction>();
    
    // optional collection properties
    public ICollection<RecipeTagOptions> Tags { get; set; } = new List<RecipeTagOptions>();
    public ICollection<KitchenTool> Tools { get; set; } = new List<KitchenTool>();

    // enums
    public DifficultyLevel DifficultyLevel { get; set; }
    public Category Category { get; set; }
    public Region Region { get; set; }
}

