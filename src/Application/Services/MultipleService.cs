using Application.Interfaces.Services;
using Application.ViewModel.Question;

namespace Application.Services;

public sealed class MultipleService : IMultipleService
{
	public MultipleViewModel GetQuestion() => new()
	{
		Organizer = "FUVEST",
		Year = 2014,
		Correct = 'A',
		Statement = "O rótulo de uma lata de desodorante em aerosol apresenta, entre outras, as seguintes informações: “Propelente: gás butano. Mantenha longe do fogo”. A principal razão dessa advertência é:",
		A = "O aumento da temperatura faz aumentar a pressão do gás no interior da lata, o que pode causar uma explosão.",
		B = "A lata é feita de alumínio, que, pelo aquecimento, pode reagir com o oxigênio do ar.",
		C = "O aquecimento provoca o aumento do volume da lata, com a consequente condensação do gás em seu interior.",
		D = "O aumento da temperatura provoca a polimerização do gás butano, inutilizando o produto.",
		E = "A lata pode se derreter e reagir com as substâncias contidas em seu interior, inutilizando o produto."
	};
}
