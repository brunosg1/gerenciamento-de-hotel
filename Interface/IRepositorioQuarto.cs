using Projeto_UML.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Interface
{
    public interface IRepositorioQuarto
    {
        void InserirQuarto(Quarto quarto);
        void AlterarQuarto(Quarto quarto);
        void RemoverQuarto(Quarto quarto);
        Quarto ObterQuarto(int numero);
        List<Quarto> ListaQuarto();
    }

}
