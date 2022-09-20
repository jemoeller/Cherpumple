using System.ComponentModel.DataAnnotations;

namespace Cherpumple.Domain.Entities;

[Flags]
public enum Categories
    {
      
        None = 0,
        Breakfast = 1 << 0,
        Dinner = 2 << 1,
        Lunch = 3 << 2,
        Brunch = 4 << 3,
        Appetizer = 5 << 4,
        Desert = 6 << 5,
        Cake = 7 << 6,
    }