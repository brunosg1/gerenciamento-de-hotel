using Projeto_UML.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class Fatura
    {
        private static int contadorId = 0;
        public int IDFatura { get; private set; }
        public float Valor { get; set; }
        public DateOnly DataVencimento { get; set; }
        public string? Descricao { get; set; }

        public Fatura() { IDFatura = ++contadorId; }

        IPagamento GerarMetodoPagamento(string meioDePagamento)
        {
            throw new NotImplementedException();
        }
    }

}
