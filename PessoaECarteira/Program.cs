namespace PessoaECarteira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Pessoa e Carteira de Motorista (0..1) ===");

            // Passo 1: Criar pessoa sem carteira
            Pessoa pessoa = new Pessoa("João");
            Console.WriteLine($"Pessoa criada: {pessoa.Nome}");
            Console.WriteLine($"Carteira inicial: {(pessoa.Carteira == null ? "nenhuma" : pessoa.Carteira.Numero)}");

            // Passo 2: Criar carteira e atribuir à pessoa
            CarteiraMotorista carteira = new CarteiraMotorista("123456", pessoa);
            bool atribuida = pessoa.AtribuirCarteira(carteira);
            Console.WriteLine($"Carteira atribuída: {atribuida}, Número: {pessoa.Carteira?.Numero}");

            // Passo 3: Tentar atribuir outra carteira (deve falhar)
            CarteiraMotorista outraCarteira = new CarteiraMotorista("654321", pessoa);
            bool atribuida2 = pessoa.AtribuirCarteira(outraCarteira);
            Console.WriteLine($"Tentativa de segunda carteira: {atribuida2}");

            // Passo 4: Remover carteira
            pessoa.RemoverCarteira();
            Console.WriteLine($"Carteira após remoção: {(pessoa.Carteira == null ? "nenhuma" : pessoa.Carteira.Numero)}");

            // Passo 5: Reatribuir carteira novamente
            bool reatribuida = pessoa.AtribuirCarteira(outraCarteira);
            Console.WriteLine($"Carteira reatribuída: {reatribuida}, Número: {pessoa.Carteira?.Numero}");
        }
    }
}
