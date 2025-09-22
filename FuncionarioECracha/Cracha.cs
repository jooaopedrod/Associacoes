using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioECracha
{
    internal class Cracha
    {
        public string Codigo { get; }
        public Funcionario Funcionario { get; }

        public Cracha(string codigo, Funcionario funcionario)
        {
            Codigo = string.IsNullOrWhiteSpace(codigo)
                ? throw new ArgumentException("Código obrigatório")
                : codigo;
            Funcionario = funcionario ?? throw new ArgumentNullException(nameof(funcionario));
        }
    }
}
