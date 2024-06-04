using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class Pessoa
    {
        private static int contadorId = 0;
        public int Id { get; private set; }
        public string? Documento { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Contato { get; set; }

        public Pessoa() { Id = ++contadorId; }
    }

}
