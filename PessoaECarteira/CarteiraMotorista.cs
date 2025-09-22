using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaECarteira
{
    internal class CarteiraMotorista
    {
        public string Numero { get; }
        public Pessoa Titular { get; private set; }

        public CarteiraMotorista(string numero, Pessoa titular)
        {
            Numero = string.IsNullOrWhiteSpace(numero)
                ? throw new ArgumentException("Número obrigatório")
                : numero;
            Titular = titular ?? throw new ArgumentNullException(nameof(titular));
        }

        public void RemoveTitular() => Titular = null;
    }
}
