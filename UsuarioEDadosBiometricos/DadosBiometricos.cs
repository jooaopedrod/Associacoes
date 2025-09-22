using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioEDadosBiometricos
{
    internal class DadosBiometricos
    {
        public string ImpressaoDigital { get; }
        public string ReconhecimentoFacial { get; }
        public Usuario Usuario { get; }

        public DadosBiometricos(string impressaoDigital, string reconhecimentoFacial, Usuario usuario)
        {
            ImpressaoDigital = string.IsNullOrWhiteSpace(impressaoDigital)
                ? throw new ArgumentException("Impressão digital obrigatória")
                : impressaoDigital;
            ReconhecimentoFacial = string.IsNullOrWhiteSpace(reconhecimentoFacial)
                ? throw new ArgumentException("Reconhecimento facial obrigatório")
                : reconhecimentoFacial;
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
        }
    }
}
