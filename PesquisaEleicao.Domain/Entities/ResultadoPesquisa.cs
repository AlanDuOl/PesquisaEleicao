using PesquisaEleicao.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class ResultadoPesquisa
    {
        public ResultadoPesquisa(IEnumerable<ResultadoOpcaoRespostaDto>? resultadoOpcaoesResposta)
        {
            ResultadoOpcaoesResposta = resultadoOpcaoesResposta;
            ResultadoPerguntas = new List<ResultadoPergunta>();
        }

        private IEnumerable<ResultadoOpcaoRespostaDto>? ResultadoOpcaoesResposta;
        public IList<ResultadoPergunta>? ResultadoPerguntas { get; private set; }
        public int? QuantidadeRespostasPesquisa { get; private set; }

        public void CalcularResultados()
        {

        }

        private void AdicionarResultadoPergunta(ResultadoPergunta resultadoPergunta)
        {
            ResultadoPerguntas.Add(resultadoPergunta);
        }
    }
}
