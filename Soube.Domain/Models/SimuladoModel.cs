using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public record SimuladoModel
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Nome { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataCriacao { get; set; }

    public int? TempoMaximo { get; set; }

    public int? NumQuestoes { get; set; }

    public int? NotaMaxima { get; set; }

    public int? NotaObtida { get; set; }
}
