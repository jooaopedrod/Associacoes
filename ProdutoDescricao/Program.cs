namespace ProdutoDescricao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Teste Produto e DescricaoDetalhada (0..1) ===");

            // Passo 1: Criar produto sem descrição
            Produto produto = new Produto("Notebook");
            Console.WriteLine($"Produto criado: {produto.Nome}");
            Console.WriteLine($"Descrição inicial: {(produto.Descricao == null ? "nenhuma" : produto.Descricao.Texto)}");

            // Passo 2: Criar descrição e atribuir ao produto
            DescricaoDetalhada desc = new DescricaoDetalhada("Notebook com 16GB RAM e SSD 512GB", produto);
            bool adicionada = produto.AdicionarDescricao(desc);
            Console.WriteLine($"Descrição adicionada: {adicionada}, Texto: {produto.Descricao?.Texto}");

            // Passo 3: Tentar adicionar outra descrição (deve falhar)
            DescricaoDetalhada outraDesc = new DescricaoDetalhada("Descrição extra", produto);
            bool adicionada2 = produto.AdicionarDescricao(outraDesc);
            Console.WriteLine($"Tentativa de segunda descrição: {adicionada2}");

            // Passo 4: Remover descrição
            produto.RemoverDescricao();
            Console.WriteLine($"Descrição após remoção: {(produto.Descricao == null ? "nenhuma" : produto.Descricao.Texto)}");

            // Passo 5: Reatribuir descrição novamente
            bool reatribuida = produto.AdicionarDescricao(outraDesc);
            Console.WriteLine($"Descrição reatribuída: {reatribuida}, Texto: {produto.Descricao?.Texto}");
        }
    }
}
