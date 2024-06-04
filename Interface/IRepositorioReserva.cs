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
        List<Reserva> ListaPessoa(int id);
        void RemoverReserva(int id);
        //IPagamento GerarMetodoPagamento(string meioDePagamento);
        /*void InserirFatura(Fatura fatura);
        void RemoverFatura(Fatura fatura);
        void AlterarFatura(Fatura fatura);
        List<Fatura> ListaFatura(int idFatura, Fatura fatura);*/


    }
}
