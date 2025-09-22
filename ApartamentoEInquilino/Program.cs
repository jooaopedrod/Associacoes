namespace ApartamentoEInquilino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Apartamento e Inquilino Principal (0..1) ===");

            // Passo 1: Criar apartamento sem inquilino
            Apartamento apt = new Apartamento("101");
            Console.WriteLine($"Apartamento criado: {apt.Numero}");
            Console.WriteLine($"Inquilino inicial: {(apt.InquilinoPrincipal == null ? "nenhum" : apt.InquilinoPrincipal.Nome)}");

            // Passo 2: Criar inquilino e atribuir ao apartamento
            Inquilino inquilino = new Inquilino("Carlos");
            bool atribuido = apt.AtribuirInquilino(inquilino);
            Console.WriteLine($"Inquilino atribuído: {atribuido}, Nome: {apt.InquilinoPrincipal?.Nome}");

            // Passo 3: Tentar atribuir outro inquilino (deve falhar)
            Inquilino outroInquilino = new Inquilino("Ana");
            bool atribuido2 = apt.AtribuirInquilino(outroInquilino);
            Console.WriteLine($"Tentativa de segundo inquilino: {atribuido2}");

            // Passo 4: Remover inquilino
            apt.RemoverInquilino();
            Console.WriteLine($"Inquilino após remoção: {(apt.InquilinoPrincipal == null ? "nenhum" : apt.InquilinoPrincipal.Nome)}");

            // Passo 5: Reatribuir inquilino novamente
            bool reatribuido = apt.AtribuirInquilino(outroInquilino);
            Console.WriteLine($"Inquilino reatribuído: {reatribuido}, Nome: {apt.InquilinoPrincipal?.Nome}");
        }
    }
}
