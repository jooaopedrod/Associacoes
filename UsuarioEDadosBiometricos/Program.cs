namespace UsuarioEDadosBiometricos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Usuario e Dados Biometricos (1:1) ===");

            // Passo 1: Criar usuário com dados biométricos
            Usuario usuario = new Usuario("Lucas", "digital123", "face456");
            Console.WriteLine($"Usuário criado: {usuario.Nome}");

            // Passo 2: Verificar dados biométricos associados
            Console.WriteLine($"Impressão Digital: {usuario.Dados.ImpressaoDigital}");
            Console.WriteLine($"Reconhecimento Facial: {usuario.Dados.ReconhecimentoFacial}");

            // Passo 3: Validar imutabilidade dos dados
            // usuario.Dados = new DadosBiometricos("nova", "nova", usuario); // ERRO: impossível alterar (get-only)
            Console.WriteLine("Dados biométricos são imutáveis após criação (verificado via compilação)");

            // Passo 4: Verificar referência do usuário nos dados
            Console.WriteLine($"Dados conhecem o usuário? {usuario.Dados.Usuario == usuario}");

            // Passo 5: Evidência final
            Console.WriteLine("Teste 1:1 concluído com sucesso!\n");
        }
    }
}
