using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroECapa
{
    internal class Capa
    {
        public string Cor { get; }
        public string Material { get; }
        public Livro Livro { get; }

        public Capa(string cor, string material, Livro livro)
        {
            Cor = string.IsNullOrWhiteSpace(cor)
                ? throw new ArgumentException("Cor obrigatória")
                : cor;
            Material = string.IsNullOrWhiteSpace(material)
                ? throw new ArgumentException("Material obrigatório")
                : material;
            Livro = livro ?? throw new ArgumentNullException(nameof(livro));
        }
    }
}
