namespace Cherpumple.Domain.Enums;

public enum Region
{
    Nordic,
    Indian,
    Asian,
    American
}

public class RegionOptions : BaseEntity
{
    public string Name { get; set; }
    public Region Region { get; set; }
}