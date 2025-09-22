using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteEEndereco
{
    internal class Cliente
    {
        public string Nome { get; }
        public EnderecoEntregaPreferencial? EnderecoPreferencial { get; private set; }

        public Cliente(string nome)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;
        }

        // Atribuir endereço preferencial (0..1)
        public bool DefinirEnderecoPreferencial(EnderecoEntregaPreferencial endereco)
        {
            if (endereco == null) return false;
            if (EnderecoPreferencial != null) return false; // já existe endereço
            EnderecoPreferencial = endereco;
            return true;
        }

        // Remover endereço preferencial
        public void RemoverEnderecoPreferencial()
        {
            if (EnderecoPreferencial != null)
            {
                EnderecoPreferencial.RemoverCliente();
                EnderecoPreferencial = null;
            }
        }
    }
}
