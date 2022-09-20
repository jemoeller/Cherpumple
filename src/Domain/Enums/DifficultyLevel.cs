using System.Runtime.CompilerServices;

namespace Cherpumple.Domain.Enums;

public enum DifficultyLevel
{
    Easy = 0,
    Medium = 1,
    Hard = 2,
    VeryHard = 3
}

public class DifficultyLevelOptions : BaseEntity
{
    public string Name { get;set;}
    
    public DifficultyLevel DifficultyLevel { get; set; }
}