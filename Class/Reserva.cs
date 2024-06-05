using Projeto_UML.Interface;
using Projeto_UML.Repositorio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_UML.Class
{
    public class Reserva
    {
        private static int contadorId = 0;
        public int IDReserva { get; private set; }
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
            IDReserva = ++contadorId;
        }

        public float CalcularValorTotal()
        {
            int diferencaDias = (DataDeSaida.ToDateTime(TimeOnly.MinValue) - DataDeEntrada.ToDateTime(TimeOnly.MinValue)).Days;
            return (float)(ValorDiaria*diferencaDias);
        }

        public List<Fatura> GerarFaturas(int quantidadeParcela, string meioDePagamento)
        {
            List<Fatura> faturas = new List<Fatura>();
            var valor = CalcularValorTotal();
            float valorParcela = (float)(valor / quantidadeParcela);
            DateOnly dataVencimentoInicial = (DataDeSaida.AddDays(3));

            for (int i = 0; i < quantidadeParcela; i++)
            {
                Fatura fatura = new Fatura
                {
                    Valor = valorParcela,
                    DataVencimento = dataVencimentoInicial.AddMonths(i),
                    Descricao = $"Meio de Pagamento: {meioDePagamento}, Valor Total: {valor:C}, Valor da Parcela: {valorParcela:C}"
                };

                faturas.Add(fatura);
            }

            return faturas;
        
        }
        public static Servico GerarServico()
        {
            Servico servico = new Servico();
            Console.WriteLine("Digite a descrição do serviço");
            servico.Descricao = Console.ReadLine();
            Console.WriteLine("Digite a valor do serviço");
            servico.Valor = Console.Read();
            servico.Data = DateOnly.FromDateTime(DateTime.Now);
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
