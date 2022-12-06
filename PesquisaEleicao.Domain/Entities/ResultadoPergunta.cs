using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class ResultadoPergunta
    {
        public IList<ResultadoOpcaoResposta>? ResultadoOpcaoesResposta { get; private set; }
        public int? QuantidadeRespostasPergunta { get; private set; }

        public ResultadoPergunta(int quantidadeRespostasPergunta)
        {
            ResultadoOpcaoesResposta = new List<ResultadoOpcaoResposta>();
            QuantidadeRespostasPergunta = quantidadeRespostasPergunta;
        }

        public void AdicionarResultadoOpcaoResposta(ResultadoOpcaoResposta resultadoOpcaoResposta)
        {
            ResultadoOpcaoesResposta.Add(resultadoOpcaoResposta);
        }
    }
}
