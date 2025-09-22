namespace PedidoECupom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Pedido e Cupom de Desconto (0..1) ===");

            // Passo 1: Criar pedido sem cupom
            Pedido pedido = new Pedido(1001);
            Console.WriteLine($"Pedido criado: {pedido.Numero}");
            Console.WriteLine($"Cupom inicial: {(pedido.Cupom == null ? "nenhum" : pedido.Cupom.Codigo)}");

            // Passo 2: Criar cupom e aplicar no pedido
            CupomDesconto cupom = new CupomDesconto("PROMO10", 10, pedido);
            bool aplicado = pedido.AplicarCupom(cupom);
            Console.WriteLine($"Cupom aplicado: {aplicado}, Código: {pedido.Cupom?.Codigo}");

            // Passo 3: Tentar aplicar outro cupom (deve falhar)
            CupomDesconto outroCupom = new CupomDesconto("PROMO20", 20, pedido);
            bool aplicado2 = pedido.AplicarCupom(outroCupom);
            Console.WriteLine($"Tentativa de segundo cupom: {aplicado2}");

            // Passo 4: Remover cupom
            pedido.RemoverCupom();
            Console.WriteLine($"Cupom após remoção: {(pedido.Cupom == null ? "nenhum" : pedido.Cupom.Codigo)}");

            // Passo 5: Reaplicar cupom novamente
            bool reaplicado = pedido.AplicarCupom(outroCupom);
            Console.WriteLine($"Cupom reaplicado: {reaplicado}, Código: {pedido.Cupom?.Codigo}");
        }
    }
}
