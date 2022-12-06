using PesquisaEleicao.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaEleicao.Domain.Entities
{
    public class Usuario : Entity
    {
        public string? Nome { get; private set; }
        public string? Login { get; private set; }
        public string? Senha { get; private set; }
        public Role? Role { get; private set; }
    }
}
