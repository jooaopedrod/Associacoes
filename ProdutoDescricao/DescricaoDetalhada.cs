using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoDescricao
{
    internal class DescricaoDetalhada
    {
        public string Texto { get; }
        public Produto Produto { get; private set; }

        public DescricaoDetalhada(string texto, Produto produto)
        {
            Texto = string.IsNullOrWhiteSpace(texto)
                ? throw new ArgumentException("Texto obrigatório")
                : texto;
            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
        }

        public void RemoverProduto() => Produto = null;
    }
}
