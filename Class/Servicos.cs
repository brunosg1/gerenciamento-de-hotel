using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string Descricao { get; set; }
        public DateOnly? Data { get; set; }
        public double Valor { get; set; }
    }
}
