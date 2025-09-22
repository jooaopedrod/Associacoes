namespace FuncionarioECracha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Funcionario e Cracha (1:1) ===");

            // Passo 1: Criar funcionário com crachá
            Funcionario func = new Funcionario("Ana", "CR12345");
            Console.WriteLine($"Funcionário criado: {func.Nome}");

            // Passo 2: Verificar crachá associado
            Console.WriteLine($"Crachá: {func.Cracha.Codigo}");

            // Passo 3: Validar imutabilidade do crachá
            // func.Cracha = new Cracha("CR999", func); // ERRO: impossível alterar (get-only)
            Console.WriteLine("Crachá é imutável após criação (verificado via compilação)");

            // Passo 4: Verificar referência do funcionário no crachá
            Console.WriteLine($"Crachá conhece funcionário? {func.Cracha.Funcionario == func}");

            // Passo 5: Evidência final
            Console.WriteLine("Teste 1:1 concluído com sucesso!\n");
        }
    }
}
