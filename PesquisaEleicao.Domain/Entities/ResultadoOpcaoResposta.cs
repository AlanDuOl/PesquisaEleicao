using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class ResultadoOpcaoResposta
    {
        public ResultadoOpcaoResposta(OpcaoResposta? opcaoResposta, float? percentualRespostas)
        {
            OpcaoResposta = opcaoResposta;
            PercentualRespostas = percentualRespostas;
        }

        public OpcaoResposta? OpcaoResposta { get; private set; }
        public float? PercentualRespostas { get; private set; }
    }
}
