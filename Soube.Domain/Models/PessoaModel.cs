using System.ComponentModel.DataAnnotations;

namespace Soube.Domain.Models;

public record PessoaModel
{
    protected int Id { get; set; }

    [StringLength(50)]
    protected string Nome { get; set; }

    [StringLength(50)]
    protected string Descricao { get; set; }

    [StringLength(50)]
    protected string Telefone { get; set; }

    [StringLength(13)]
    protected string Celular { get; set; }

    [StringLength(50)]
    protected string Email { get; set; }

    protected int Credencial { get; set; }

    #region model externa
    protected AutenticarModel AutenticarModel { get; set; }

    protected EnderecoModel EnderecoModel { get; set; }
    #endregion model externa
}
