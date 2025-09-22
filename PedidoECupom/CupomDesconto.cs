using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoECupom
{
    internal class CupomDesconto
    {
        public string Codigo { get; }
        public decimal Percentual { get; }
        public Pedido Pedido { get; private set; }

        public CupomDesconto(string codigo, decimal percentual, Pedido pedido)
        {
            Codigo = string.IsNullOrWhiteSpace(codigo)
                ? throw new ArgumentException("Código obrigatório")
                : codigo;
            Percentual = percentual > 0 && percentual <= 100
                ? percentual
                : throw new ArgumentException("Percentual deve ser entre 0 e 100");
            Pedido = pedido ?? throw new ArgumentNullException(nameof(pedido));
        }

        public void RemoverPedido() => Pedido = null;
    }
}
