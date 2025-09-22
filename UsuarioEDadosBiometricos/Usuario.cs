using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioEDadosBiometricos
{
    internal class Usuario
    {
        public string Nome { get; }
        public DadosBiometricos Dados { get; }

        public Usuario(string nome, string impressaoDigital, string reconhecimentoFacial)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;

            // Cria os dados biométricos no construtor garantindo 1:1
            Dados = new DadosBiometricos(impressaoDigital, reconhecimentoFacial, this);
        }
    }
}
