namespace Soube.Domain.Models;

public record SimuladoQuestaoModel
{
    public int Id { get; set; }

    public SimuladoModel Simulado { get; set; }

    public QuestaoModel Questao { get; set; }

    public AlunoModel Aluno { get; set; }
}
