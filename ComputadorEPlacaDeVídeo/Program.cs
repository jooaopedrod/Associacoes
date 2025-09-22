namespace ComputadorEPlacaDeVídeo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Computador e Placa de Vídeo Dedicada (0..1) ===");

            // Passo 1: Criar computador sem placa
            Computador pc = new Computador("PC Gamer");
            Console.WriteLine($"Computador criado: {pc.Nome}");
            Console.WriteLine($"Placa inicial: {(pc.Placa == null ? "nenhuma" : pc.Placa.Modelo)}");

            // Passo 2: Criar placa e instalar no computador
            PlacaVideoDedicada placa = new PlacaVideoDedicada("RTX 4070", 12, pc);
            bool instalada = pc.InstalarPlaca(placa);
            Console.WriteLine($"Placa instalada: {instalada}, Modelo: {pc.Placa?.Modelo}");

            // Passo 3: Tentar instalar outra placa (deve falhar)
            PlacaVideoDedicada outraPlaca = new PlacaVideoDedicada("RX 7900", 16, pc);
            bool instalada2 = pc.InstalarPlaca(outraPlaca);
            Console.WriteLine($"Tentativa de segunda placa: {instalada2}");

            // Passo 4: Desinstalar placa
            pc.DesinstalarPlaca();
            Console.WriteLine($"Placa após desinstalação: {(pc.Placa == null ? "nenhuma" : pc.Placa.Modelo)}");

            // Passo 5: Reinstalar placa novamente
            bool reinstalada = pc.InstalarPlaca(outraPlaca);
            Console.WriteLine($"Placa reinstalada: {reinstalada}, Modelo: {pc.Placa?.Modelo}");
        }
    }
}
