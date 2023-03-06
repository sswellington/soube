using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soube.Domain.Models;

public record PessoaFisicaModel : PessoaModel
{
    [Required]
    [StringLength(11)]
    public string CPF { get; set; }

    [Required]
    [StringLength(13)]
    public string RG { get; set; }

    [Required]
    [StringLength(8)]
    public string Passaporte { get; set; }

    [Required]
    [StringLength(50)]
    public string Nacionalidade { get; set; }

    [StringLength(50)]
    public string Naturalidade { get; set; }

    [Required]
    [StringLength(20)]
    public string EstadoCivil { get; set; }

    [Required]
    [StringLength(1)]
    public string Sexo { get; set; }

    [StringLength(20)]
    public string Genero { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataNascimento { get; set; }
}
