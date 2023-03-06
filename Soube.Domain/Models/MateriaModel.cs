using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public record MateriaModel
{
    public int Id { get; set; }

    [StringLength(40)]
    public string Nome { get; set; }

    [StringLength(800)]
    public string ImagemURL { get; set; }

    public int? Escolaridade { get; set; }

    public int? Nivel { get; set; }

    public SituacaoModel Situacao { get; set; }
}
