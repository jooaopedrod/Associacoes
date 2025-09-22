using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputadorEPlacaDeVídeo
{
    internal class PlacaVideoDedicada
    {
        public string Modelo { get; }
        public int MemoriaGB { get; }
        public Computador Computador { get; private set; }

        public PlacaVideoDedicada(string modelo, int memoriaGB, Computador computador)
        {
            Modelo = string.IsNullOrWhiteSpace(modelo)
                ? throw new ArgumentException("Modelo obrigatório")
                : modelo;
            MemoriaGB = memoriaGB > 0
                ? memoriaGB
                : throw new ArgumentException("Memória deve ser positiva");
            Computador = computador ?? throw new ArgumentNullException(nameof(computador));
        }

        public void RemoverComputador() => Computador = null;
    }
}
