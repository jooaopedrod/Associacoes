using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteEEndereco
{
    internal class EnderecoEntregaPreferencial
    {
        public string Rua { get; }
        public string Cidade { get; }
        public Cliente Cliente { get; private set; }

        public EnderecoEntregaPreferencial(string rua, string cidade, Cliente cliente)
        {
            Rua = string.IsNullOrWhiteSpace(rua)
                ? throw new ArgumentException("Rua obrigatória")
                : rua;
            Cidade = string.IsNullOrWhiteSpace(cidade)
                ? throw new ArgumentException("Cidade obrigatória")
                : cidade;
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        }

        public void RemoverCliente() => Cliente = null;
    }
}
