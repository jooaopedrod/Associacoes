using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartamentoEInquilino
{
    internal class Apartamento
    {
        public string Numero { get; }
        public Inquilino? InquilinoPrincipal { get; private set; }

        public Apartamento(string numero)
        {
            Numero = string.IsNullOrWhiteSpace(numero)
                ? throw new ArgumentException("Número do apartamento obrigatório")
                : numero;
        }

        // Atribuir inquilino principal (0..1)
        public bool AtribuirInquilino(Inquilino inquilino)
        {
            if (inquilino == null) return false;
            if (InquilinoPrincipal != null) return false; // já existe inquilino
            if (inquilino.ApartamentoPrincipal != null) return false; // inquilino já em outro apartamento

            InquilinoPrincipal = inquilino;
            inquilino.DefinirApartamento(this);
            return true;
        }

        // Remover inquilino
        public void RemoverInquilino()
        {
            if (InquilinoPrincipal != null)
            {
                InquilinoPrincipal.RemoverApartamento();
                InquilinoPrincipal = null;
            }
        }
    }
}
