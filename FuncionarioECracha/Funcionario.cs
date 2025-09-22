using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioECracha
{
    internal class Funcionario
    {
        public string Nome { get; }
        public Cracha Cracha { get; }

        public Funcionario(string nome, string codigoCracha)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;

            // Cria o crachá no construtor garantindo 1:1
            Cracha = new Cracha(codigoCracha, this);
        }
    }
}
