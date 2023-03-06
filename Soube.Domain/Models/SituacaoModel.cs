using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public record SituacaoModel
{
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Criado { get; set; }

    public int CriadoPor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Atualizado { get; set; }

    public int AtualizadoPor { get; set; }

    [Required]
    public bool? Ativo { get; set; }

    public PessoaFisicaModel Administrador { get; set; }
}
