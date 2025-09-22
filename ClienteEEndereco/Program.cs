namespace ClienteEEndereco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Cliente e Endereço de Entrega Preferencial (0..1) ===");

            // Passo 1: Criar cliente sem endereço
            Cliente cliente = new Cliente("Maria");
            Console.WriteLine($"Cliente criado: {cliente.Nome}");
            Console.WriteLine($"Endereço inicial: {(cliente.EnderecoPreferencial == null ? "nenhum" : cliente.EnderecoPreferencial.Rua)}");

            // Passo 2: Criar endereço e atribuir ao cliente
            EnderecoEntregaPreferencial endereco = new EnderecoEntregaPreferencial("Rua A, 123", "São Paulo", cliente);
            bool definido = cliente.DefinirEnderecoPreferencial(endereco);
            Console.WriteLine($"Endereço definido: {definido}, Rua: {cliente.EnderecoPreferencial?.Rua}");

            // Passo 3: Tentar definir outro endereço (deve falhar)
            EnderecoEntregaPreferencial outroEndereco = new EnderecoEntregaPreferencial("Rua B, 456", "São Paulo", cliente);
            bool definido2 = cliente.DefinirEnderecoPreferencial(outroEndereco);
            Console.WriteLine($"Tentativa de segundo endereço: {definido2}");

            // Passo 4: Remover endereço
            cliente.RemoverEnderecoPreferencial();
            Console.WriteLine($"Endereço após remoção: {(cliente.EnderecoPreferencial == null ? "nenhum" : cliente.EnderecoPreferencial.Rua)}");

            // Passo 5: Reatribuir endereço novamente
            bool reatribuido = cliente.DefinirEnderecoPreferencial(outroEndereco);
            Console.WriteLine($"Endereço reatribuído: {reatribuido}, Rua: {cliente.EnderecoPreferencial?.Rua}");
        }
    }
}
