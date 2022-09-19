using System.ComponentModel.DataAnnotations;

namespace Cherpumple.Domain.Enums;

public interface BaseEnum<TEnum>
{
    [Required]
    public string EnumName { get; set; }
    public TEnum EnumId { get; set; }
    
}