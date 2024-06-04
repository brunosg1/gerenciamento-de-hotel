using Projeto_UML.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Interface
{
    public interface IRepositorioReserva
    {
        void FazerReserva(Reserva reserva);
        void AlterarReserva(Reserva reserva);
        bool VerificarDisponibilidade(int numeroID, DateOnly dataDeEntrada, DateOnly dataDeSaida);
        List<DateOnly> ListarDiasDisponiveis(int numeroID, DateOnly dataDeEntrada, DateOnly dataDeSaida);
        List<Reserva> ListaReserva(int id);
        void RemoverReserva(int id);
        //IPagamento GerarMetodoPagamento(string meioDePagamento);
        


    }
}
