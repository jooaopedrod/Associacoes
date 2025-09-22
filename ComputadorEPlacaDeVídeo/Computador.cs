using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputadorEPlacaDeVídeo
{
    internal class Computador
    {
        public string Nome { get; }
        public PlacaVideoDedicada? Placa { get; private set; }

        public Computador(string nome)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;
        }

        // Instalar placa de vídeo (0..1)
        public bool InstalarPlaca(PlacaVideoDedicada placa)
        {
            if (placa == null) return false;
            if (Placa != null) return false; // já existe placa
            Placa = placa;
            return true;
        }

        // Desinstalar placa de vídeo
        public void DesinstalarPlaca()
        {
            if (Placa != null)
            {
                Placa.RemoverComputador();
                Placa = null;
            }
        }
    }
}
