using Projeto_UML.Class;
using Projeto_UML.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Repositorio
{
    public class RepositorioReserva : IRepositorioReserva
    {
        private List<Reserva> reservas = new List<Reserva>();

        public void FazerReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public void AlterarReserva(Reserva reserva)
        {
            var index = reservas.FindIndex(r => r.IDReserva == reserva.IDReserva);
            if (index != -1)
            {
                reservas[index] = reserva;
            }
        }

        public bool VerificarDisponibilidade(int numeroID, DateOnly dataDeEntrada, DateOnly dataDeSaida)
        {
            foreach (var reserva in reservas)
            {
                if (reserva.Quarto.NumeroID == numeroID &&
                    ((dataDeEntrada >= reserva.DataDeEntrada && dataDeEntrada < reserva.DataDeSaida) || 
                    (dataDeSaida > reserva.DataDeEntrada && dataDeSaida <= reserva.DataDeSaida) || 
                    (dataDeEntrada <= reserva.DataDeEntrada && dataDeSaida >= reserva.DataDeSaida))) 
                {
                    return false;
                }
            }
            return true;
        }

        public List<DateOnly> ListarDiasDisponiveis(int numeroID, DateOnly dataDeEntrada, DateOnly dataDeSaida)
        {
            var diasDisponiveis = new List<DateOnly>();

            for (var date = dataDeEntrada; date <= dataDeSaida; date = date.AddDays(1))
            {
                if (VerificarDisponibilidade(numeroID, date, date.AddDays(1)))
                {
                    diasDisponiveis.Add(date);
                }
            }

            return diasDisponiveis;
        }

        public List<Reserva> ListaReserva(int id)
        {
            return reservas.Where(r => r.Hospede.Id == id).ToList();
        }

        public void RemoverReserva(int id)
        {
            var reserva = reservas.FirstOrDefault(r => r.IDReserva == id);
            if (reserva != null)
            {
                reservas.Remove(reserva);
            }
        }
    }
}
