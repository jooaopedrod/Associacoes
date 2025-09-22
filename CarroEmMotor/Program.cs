namespace CarroEMotor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Carro e Motor (1:1) ===");

            // Passo 1: Criar carro com motor
            Carro carro = new Carro("Toyota", "Corolla", "VVT-i", 180);
            Console.WriteLine($"Carro criado: {carro.Marca} {carro.Modelo}");

            // Passo 2: Verificar motor associado
            Console.WriteLine($"Motor associado: {carro.Motor.Modelo}, {carro.Motor.Potencia}cv");

            // Passo 3: Validar imutabilidade do motor
            // carro.Motor = new Motor("NovoMotor", 200, carro); // ERRO: impossível alterar (get-only)
            Console.WriteLine("Motor é imutável após criação (verificado via compilação)");

            // Passo 4: Verificar referência do carro no motor
            Console.WriteLine($"Motor conhece carro? {carro.Motor.Carro == carro}");

            // Passo 5: Evidência final
            Console.WriteLine("Teste 1:1 concluído com sucesso!\n");
        }
    }
}
