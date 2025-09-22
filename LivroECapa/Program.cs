namespace LivroECapa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Livro e Capa (1:1) ===");

            // Passo 1: Criar livro com capa
            Livro livro = new Livro("Dom Quixote", "Miguel de Cervantes", "Vermelho", "Couro");
            Console.WriteLine($"Livro criado: {livro.Titulo} de {livro.Autor}");

            // Passo 2: Verificar capa associada
            Console.WriteLine($"Capa: {livro.Capa.Cor}, Material: {livro.Capa.Material}");

            // Passo 3: Validar imutabilidade da capa
            // livro.Capa = new Capa("Azul", "Tecido", livro); // ERRO: impossível alterar (get-only)
            Console.WriteLine("Capa é imutável após criação (verificado via compilação)");

            // Passo 4: Verificar referência do livro na capa
            Console.WriteLine($"Capa conhece livro? {livro.Capa.Livro == livro}");

            // Passo 5: Evidência final
            Console.WriteLine("Teste 1:1 concluído com sucesso!\n");
        }
    }
}
