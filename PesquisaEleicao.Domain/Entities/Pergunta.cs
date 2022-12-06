using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class Pergunta : Entity
    {
        public string? Descricao { get; private set; }
        public IEnumerable<OpcaoResposta>? OpcaoesResposta { get; private set; }
    }
}
