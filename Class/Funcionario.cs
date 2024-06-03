using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class Funcionario : Pessoa
    {
        public string? Ctps { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Cargo { get; set; }
    }
}
