using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroEMotor
{
    internal class Motor
    {
        public string Modelo { get; }
        public int Potencia { get; }
        public Carro Carro { get; }

        public Motor(string modelo, int potencia, Carro carro)
        {
            Modelo = string.IsNullOrWhiteSpace(modelo)
                ? throw new ArgumentException("Modelo do motor obrigatório")
                : modelo;
            Potencia = potencia > 0
                ? potencia
                : throw new ArgumentException("Potência deve ser positiva");
            Carro = carro ?? throw new ArgumentNullException(nameof(carro));
        }
    }
}
