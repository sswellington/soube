using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public record QuestaoModel
{
    public int Id { get; set; }

    [StringLength(800)]
    public string Enunciado { get; set; }

    [StringLength(200)]
    public string Alternativa { get; set; }

    [StringLength(40)]
    public string Gabarito { get; set; }

    [StringLength(200)]
    public string Comentario { get; set; }

    [Column(TypeName = "date")]
    public DateTime Ano { get; set; }

    public SimuladoModel Simulado { get; set; }

    public MateriaModel Materia { get; set; }

    public PessoaJuridicaModel Banca { get; set; }

    public SituacaoModel Situacao { get; set; }
}
