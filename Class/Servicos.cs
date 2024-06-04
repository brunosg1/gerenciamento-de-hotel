using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class Servico
    {
        private static int contadorId = 0;
        public int IdServico { get; private set; }
        public string Descricao { get; set; }
        public DateOnly? Data { get; set; }
        public double Valor { get; set; }

        public Servico() { IdServico = ++contadorId; }
    }
}
