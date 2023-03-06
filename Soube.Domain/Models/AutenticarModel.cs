using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public class AutenticarModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    protected string Login { get; set; }

    [Required]
    [StringLength(16)]
    protected string Senha { get; set; }
}
