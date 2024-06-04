using Projeto_UML.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Interface
{
    public interface IRepositorioFatura
    {
        void InserirFatura(Fatura fatura);
        void RemoverFatura(Fatura fatura);
        void AlterarFatura(Fatura fatura);
        List<Fatura> ListaFatura(int idFatura);
    }
}
