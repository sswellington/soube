// Função para manipular as classes dos ícones
function handleIcon(id) {
	// Remover a classe "fill" do elemento com id "homeIcon"
	document.getElementById("homeIcon").classList.remove("fill");

	// Adicionar a classe "fill" ao elemento com id "disciplineIcon"
	document.getElementById(id).classList.add("fill");
}

// Evento DOMContentLoaded para chamar a função quando a página for carregada
document.addEventListener("DOMContentLoaded", handleDisciplineIcon);
