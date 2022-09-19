namespace Cherpumple.Domain.Entities;

public class Ingredient : BaseEntity
{
    public string Name { get; set; }
    
    public double Quantity { get; set; }
    
    public MeasurementUnit Unit { get; set; }
    
    public FoodGroup FoodGroup { get; set; }
    
    public string ClarificationText { get; set; }
}