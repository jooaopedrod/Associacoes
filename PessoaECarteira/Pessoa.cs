using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaECarteira
{
    internal class Pessoa
    {
        public string Nome { get; }
        public CarteiraMotorista? Carteira { get; private set; }

        public Pessoa(string nome)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentException("Nome obrigatório")
                : nome;
        }

        // Método de domínio para atribuir carteira
        public bool AtribuirCarteira(CarteiraMotorista carteira)
        {
            if (carteira == null) return false;
            if (Carteira != null) return false; // já tem carteira
            Carteira = carteira;
            return true;
        }

        // Método de domínio para remover carteira
        public void RemoverCarteira()
        {
            if (Carteira != null)
            {
                Carteira.RemoveTitular();
                Carteira = null;
            }
        }
    }
}
