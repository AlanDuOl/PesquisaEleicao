using PesquisaEleicao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Interfaces
{
    public interface IPesquisaRepository
    {
        public void SalvarRespostaPesquisa(IEnumerable<Resposta> respostaPesquisa);
        public void CriarPergunta(Pergunta pergunta);
        public void CriarPesquisa(Pesquisa pesquisa);
        public void AdicionarPerguntaPesquisa(PerguntaPesquisa perguntaPesquisa);
        public ResultadoPesquisa ObterResultadoPesquisa(Pesquisa pesquisa);
        public IEnumerable<Pergunta> ObterPerguntasPesquisa(Pesquisa pesquisa);
    }
}
