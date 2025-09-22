using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroECapa
{
    internal class Livro
    {
        public string Titulo { get; }
        public string Autor { get; }
        public Capa Capa { get; }

        public Livro(string titulo, string autor, string corCapa, string materialCapa)
        {
            Titulo = string.IsNullOrWhiteSpace(titulo)
                ? throw new ArgumentException("Título obrigatório")
                : titulo;
            Autor = string.IsNullOrWhiteSpace(autor)
                ? throw new ArgumentException("Autor obrigatório")
                : autor;

            // Cria a capa no construtor garantindo 1:1
            Capa = new Capa(corCapa, materialCapa, this);
        }
    }
}
