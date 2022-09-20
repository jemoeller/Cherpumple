using System.ComponentModel.DataAnnotations;

namespace Cherpumple.Domain.Enums;

public enum MeasurementUnit
{
    Grams,
    Kilograms,
    Liter,
    Deciliter,
    Milliliter,
    Clove,
}

public class MeasurementUnitOptions : BaseEntity
{
    public string Name { get; set; }
    
    public MeasurementUnit MeasurementUnit { get; set; }
}