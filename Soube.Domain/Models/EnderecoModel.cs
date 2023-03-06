using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public record EnderecoModel
{
    protected int Id { get; set; }

    [StringLength(8)]
    protected string CEP { get; set; }

    [Required]
    [StringLength(80)]
    protected string Nome { get; set; }

    [Required]
    [StringLength(50)]
    protected string Pais { get; set; }

    [StringLength(2)]
    protected string UF { get; set; }

    [StringLength(50)]
    protected string Cidade { get; set; }

    [StringLength(30)]
    protected string Bairro { get; set; }

    [StringLength(10)]
    protected string Numero { get; set; }

    [StringLength(50)]
    protected string Complemento { get; set; }

    [Required]
    protected bool ZonaUrbana { get; set; }
}
