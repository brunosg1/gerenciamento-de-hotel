using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class PessoaFactory
    {
        public static Pessoa CriarPessoa(string tipo)
        {
            switch (tipo)
            {
                case "Funcionario":
                    return new Funcionario();
                case "Hospede":
                    return new Hospede();
                default:
                    return new Pessoa();
            }
        }
    }
}
