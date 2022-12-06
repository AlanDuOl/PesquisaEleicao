using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class PerguntaPesquisa : Entity
    {
        public Pesquisa? Pesquisa { get; private set; }
        public Pergunta? Pergunta { get; private set; }
    }
}
