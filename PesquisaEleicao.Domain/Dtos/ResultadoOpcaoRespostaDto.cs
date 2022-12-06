using PesquisaEleicao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Dtos
{
    public class ResultadoOpcaoRespostaDto
    {
        public Pesquisa? Pesquisa { get; private set; }
        public Pergunta? Pergunta { get; private set; }
        public OpcaoResposta? OpcaoResposta { get; private set; }
        public int? QuantidadeRespostas { get; private set; }
    }
}
