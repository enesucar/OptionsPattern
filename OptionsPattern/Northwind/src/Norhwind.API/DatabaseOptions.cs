using System.ComponentModel.DataAnnotations;

namespace Norhwind.API;

public class DatabaseOptions
{
    [Required]
    public string Url { get; set; } = null!;

    [Required]
    public string User { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;
}
