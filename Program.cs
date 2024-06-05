using Projeto_UML.Class;
using Projeto_UML.Interface;
using Projeto_UML.Repositorio;
using System.ComponentModel.Design;

namespace Projeto_UML
{
    class Program
    {
        static void Main(string[] args)
        {

            IRepositorioReserva repositorioReserva = new RepositorioReserva();
            IRepositorioQuarto repositorioQuarto = new RepositorioQuarto();
            IRepositorioPessoa repositorioPessoa = new RepositorioPessoa();
            IRepositorioFatura repositorioFatura = new RepositorioFatura();
            RepositorioServico repositorioServico = new RepositorioServico();

            Pessoa hospede1 = PessoaFactory.CriarPessoa("Hospede");
            hospede1.Contato = "1234";
            hospede1.Endereco = "rua 1234";
            hospede1.Documento = "123";
            hospede1.Nome = "Kleber";

            Pessoa hospede3 = PessoaFactory.CriarPessoa("Hospede");
            hospede3.Contato = "5678";
            hospede3.Endereco = "rua 5678";
            hospede3.Documento = "567";
            hospede3.Nome = "Gustavo";

            Pessoa hospede2 = PessoaFactory.CriarPessoa("Hospede");
            hospede2.Contato = "91011";
            hospede2.Endereco = "rua 91011";
            hospede2.Documento = "91";
            hospede2.Nome = "Fagner";

            Funcionario funcionario = new Funcionario
            {
                Nome = "Maria",
                Documento = "987",
                Contato = "987",
                Endereco = "rua 987",
                Email = "maria.com",
                Cargo = "Recepcionista",
                Senha = "987",
                Ctps = "987"
            };
            repositorioPessoa.Inserir(funcionario);
            repositorioPessoa.Inserir(hospede1);
            repositorioPessoa.Inserir(hospede2);
            repositorioPessoa.Inserir(hospede3);

            Quarto quarto1 = new Quarto { Descricao = "1 cama casal", NumeroID = 101, Valor = 50 };
            Quarto quarto2 = new Quarto { Descricao = "1 cama casal e 1 solteiro", NumeroID = 102, Valor = 75 };
            Quarto quarto3 = new Quarto { Descricao = "2 cama casal", NumeroID = 103, Valor = 100 };
            Quarto quarto4 = new Quarto { Descricao = "2 cama solteiro", NumeroID = 104, Valor = 50 };
            repositorioQuarto.InserirQuarto(quarto1);
            repositorioQuarto.InserirQuarto(quarto2);
            repositorioQuarto.InserirQuarto(quarto3);
            repositorioQuarto.InserirQuarto(quarto4);

            Reserva reserva1 = new Reserva(repositorioQuarto, repositorioReserva)
            {
                DataDeEntrada = new DateOnly(2024,06,05),
                DataDeSaida = new DateOnly(2024,06,10),
                Funcionario = funcionario,
                Hospede = hospede1,
                Quarto = quarto3,
                ValorDiaria = (float)quarto3.Valor
            };

            repositorioReserva.FazerReserva(reserva1);
            Console.WriteLine($"Valor total: R${reserva1.CalcularValorTotal()}");
            var faturas = reserva1.GerarFaturas(3, "Credito");
            foreach (var fatura in faturas)
            {
                Console.WriteLine($"ID Fatura: {fatura.IDFatura}");
                Console.WriteLine($"Valor: {fatura.Valor:C}");
                Console.WriteLine($"Data de Vencimento: {fatura.DataVencimento}");
                Console.WriteLine($"Descrição: {fatura.Descricao}");
                repositorioFatura.InserirFatura(fatura);
                Console.WriteLine();
            }

            var servico = Reserva.GerarServico();
            repositorioServico.InserirServico(servico);
            var quartoEntrada = new DateOnly(2024, 06, 03);
            var quartoSaida = new DateOnly(2024, 06, 10);
            var quartosDisponivel = reserva1.QuartoDisponivel(quartoEntrada,quartoSaida);
            foreach(var quartos in quartosDisponivel)
            {
                Console.WriteLine($"{quartos.Descricao}, Valor Diaria:R${quartos.Valor}, Numero: {quartos.NumeroID} ");
            }


            
            



        }
    }
   
}

