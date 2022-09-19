using Microsoft.EntityFrameworkCore;

namespace Cherpumple.Domain.Entities;


public class Direction : BaseEntity
{
    public string Description { get; set; }
    
    public int Step { get; set; } // the "step nr". if this is the third direction out of 5, then this is 3.
    
    
    // dependant on recipe entity
    public Recipe Recipe { get; set; }
    
    public int RecipeId { get; set; }
}