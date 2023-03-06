namespace Soube.Domain.Models;

public record AlunoModel : PessoaFisicaModel
{
    public int Score { get; set; }

    public int QuestoesRealizadas { get; set; }

    public int QuestoesAcertadas { get; set; }
}
