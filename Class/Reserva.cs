using Projeto_UML.Interface;
using Projeto_UML.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        private IRepositorioQuarto _repositorioQuarto;
        private IRepositorioReserva _repositorioReserva;

        public Reserva(IRepositorioQuarto repositorioQuarto, IRepositorioReserva repositorioReserva)
        {
            _repositorioQuarto = repositorioQuarto;
            _repositorioReserva = repositorioReserva;
        }

        public float CalcularValorTotal()
        {
            return ValorDiaria;
        }
        public Servico GerarServico()
        {
            Servico servico = new Servico();
            return servico;
        }
   

        public List<Quarto> QuartoDisponivel(DateOnly dataDeEntrada, DateOnly dataDeSaida)
        {
            List<Quarto> quartosDisponiveis = new List<Quarto>();
            var todosQuartos = _repositorioQuarto.ListaQuarto();
            foreach (var quarto in todosQuartos)
            {
                if (_repositorioReserva.VerificarDisponibilidade(quarto.NumeroID, dataDeEntrada, dataDeSaida))
                {
                    quartosDisponiveis.Add(quarto);
                }
            }
            return quartosDisponiveis;
        }
    }
}
