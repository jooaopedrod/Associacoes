using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoDescricao
{
    internal class Produto
    {
        public string Nome { get; }
        public DescricaoDetalhada? Descricao { get; private set; }

        public Produto(string nome)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;
        }

        // Atribuir descrição (0..1)
        public bool AdicionarDescricao(DescricaoDetalhada descricao)
        {
            if (descricao == null) return false;
            if (Descricao != null) return false; // já existe descrição
            Descricao = descricao;
            return true;
        }

        // Remover descrição
        public void RemoverDescricao()
        {
            if (Descricao != null)
            {
                Descricao.RemoverProduto();
                Descricao = null;
            }
        }
    }
}
