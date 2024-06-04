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

            Quarto quarto1 = new Quarto { Descricao = "Solteiro", NumeroID = 101, Valor = 50 };
            Quarto quarto2 = new Quarto { Descricao = "Solteiro", NumeroID = 102, Valor = 50 };
            Quarto quarto3 = new Quarto { Descricao = "Solteiro", NumeroID = 103, Valor = 50 };
            Quarto quarto4 = new Quarto { Descricao = "Casal", NumeroID = 104, Valor = 100 };
            repositorioQuarto.InserirQuarto(quarto1);
            repositorioQuarto.InserirQuarto(quarto2);
            repositorioQuarto.InserirQuarto(quarto3);
            repositorioQuarto.InserirQuarto(quarto4);
            string menu;
            do
            {
                Console.WriteLine("Digite uma opção");
                
                Console.WriteLine("1-Adicionar Hospede");
                Console.WriteLine("2-Fazer Reserva");
                Console.WriteLine("");
                Console.WriteLine("1-Adicionar Hospede");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("1-Adicionar Hospede");
                        break;
                    case "2":
                        Console.WriteLine("2-Fazer Reserva");
                        break;
                    case "3":
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.WriteLine("1-Adicionar Hospede");
                        break;
                    default:
                        break;
                }
            } while (menu != "5");
 
            




        }
    }
   
}

