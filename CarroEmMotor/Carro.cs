using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroEMotor
{
    internal class Carro
    {
        public string Marca { get; }
        public string Modelo { get; }
        public Motor Motor { get; }

        public Carro(string marca, string modelo, string modeloMotor, int potenciaMotor)
        {
            Marca = string.IsNullOrWhiteSpace(marca)
                ? throw new ArgumentException("Marca obrigatória")
                : marca;
            Modelo = string.IsNullOrWhiteSpace(modelo)
                ? throw new ArgumentException("Modelo obrigatório")
                : modelo;

            // Cria o motor no construtor garantindo 1:1
            Motor = new Motor(modeloMotor, potenciaMotor, this);
        }
    }
}
