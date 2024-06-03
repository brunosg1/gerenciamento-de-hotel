using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class Reserva
    {
        public int IDReserva { get; set; }
        public float ValorDiaria { get; set; }
        public DateOnly DataDeEntrada { get; set; }

        public DateOnly DataDeSaida { get; set; }
        public  Pessoa Funcionario { get; set; }
        public  Pessoa Hospede { get; set; }
        public Quarto Quarto { get; set; }

        public float CalcularValorTotal()
        {
            return ValorDiaria;
        }

       
        

    }
}
