using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartamentoEInquilino
{
    internal class Inquilino
    {
        public string Nome { get; }
        public Apartamento? ApartamentoPrincipal { get; private set; }

        internal Inquilino(string nome)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;
        }

        public void DefinirApartamento(Apartamento apartamento) => ApartamentoPrincipal = apartamento;
        public void RemoverApartamento() => ApartamentoPrincipal = null;
    }
}
