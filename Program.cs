using Projeto_UML.Class;
using Projeto_UML.Interface;
using Projeto_UML.Repositorio;

namespace Projeto_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do repositório de reservas
            IRepositorioReserva repositorioReserva = new RepositorioReserva();

            // Criação de um novo hospede
            Pessoa hospede = new Pessoa
            {
                Id = 1,
                Nome = "João da Silva",
                Documento = "123.456.789-00",
                Endereco = "(11) 1234-5678",
                Contato = "joao.silva@example.com"
            };

            // Criação de um novo quarto
            Quarto quarto = new Quarto
            {
                NumeroID = 101,
                Descricao= "Solteiro",
                Valor=100

            };

            // Criação de uma nova reserva
            Reserva reserva = new Reserva
            {
                IDReserva = 1,
                Hospede = hospede,
                Quarto = quarto,
                DataDeEntrada = new DateOnly(2024, 6, 10),
                DataDeSaida = new DateOnly(2024, 6, 15),
            };

            // Fazer uma reserva
            repositorioReserva.FazerReserva(reserva);

            // Verificar disponibilidade
            bool disponivel = repositorioReserva.VerificarDisponibilidade(101, new DateOnly(2024, 6, 5), new DateOnly(2024, 6, 9));
            Console.WriteLine("Quarto 101 disponível de 05/06/2024 a 09/06/2024: " + disponivel);

            disponivel = repositorioReserva.VerificarDisponibilidade(101, new DateOnly(2024, 6, 11), new DateOnly(2024, 6, 14));
            Console.WriteLine("Quarto 101 disponível de 11/06/2024 a 14/06/2024: " + disponivel);

            // Listar dias disponíveis
            List<DateOnly> diasDisponiveis = repositorioReserva.ListarDiasDisponiveis(reserva.Quarto.NumeroID, new DateOnly(2024, 6, 5), new DateOnly(2024, 6, 20));
            Console.WriteLine("Dias disponíveis para o quarto 101:");
            foreach (var dia in diasDisponiveis)
            {
                Console.WriteLine(dia.ToShortDateString());
            }

            // Listar reservas de uma pessoa
            List<Reserva> reservasPessoa = repositorioReserva.ListaPessoa(1);
            Console.WriteLine("Reservas para a pessoa com ID 1:");
            foreach (var res in reservasPessoa)
            {
                Console.WriteLine($"Reserva ID: {res.IDReserva}, Quarto: {res.Quarto.NumeroID}, Entrada: {res.DataDeEntrada}, Saída: {res.DataDeSaida}");
            }

            // Remover uma reserva
            repositorioReserva.RemoverReserva(1);
            Console.WriteLine("Reserva ID 1 removida.");
        }
    }

}