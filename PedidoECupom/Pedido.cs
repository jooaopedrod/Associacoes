using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoECupom
{
    internal class Pedido
    {
        public int Numero { get; }
        public CupomDesconto? Cupom { get; private set; }

        public Pedido(int numero)
        {
            if (numero <= 0) throw new ArgumentException("Número do pedido deve ser positivo");
            Numero = numero;
        }

        // Aplicar cupom (0..1)
        public bool AplicarCupom(CupomDesconto cupom)
        {
            if (cupom == null) return false;
            if (Cupom != null) return false; // já existe cupom
            Cupom = cupom;
            return true;
        }

        // Remover cupom
        public void RemoverCupom()
        {
            if (Cupom != null)
            {
                Cupom.RemoverPedido();
                Cupom = null;
            }
        }
    }
}
