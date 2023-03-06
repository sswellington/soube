using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soube.Domain.Models;

public record PessoaJuridicaModel : PessoaModel
{
    [StringLength(14)]
    public string CNPJ { get; set; }

    [StringLength(80)]
    public string Fantasia { get; set; }

    [StringLength(50)]
    public string RazaoSocial { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataInicioAtividade { get; set; }

    [StringLength(20)]
    public string DescricaoSituacaoCadastral { get; set; }

    public bool? Matriz { get; set; }

}
