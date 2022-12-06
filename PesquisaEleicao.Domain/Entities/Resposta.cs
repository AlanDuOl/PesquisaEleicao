using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class Resposta : Entity
    {
        public Pesquisa? Pesquisa { get; private set; }
        public Pergunta? Pergunta { get; private set; }
        public OpcaoResposta? OpcaoResposta { get; private set; }
    }
}
