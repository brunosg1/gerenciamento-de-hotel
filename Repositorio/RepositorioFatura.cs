using Projeto_UML.Class;
using Projeto_UML.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_UML.Repositorio
{
    public class RepositorioFatura : IRepositorioFatura
    {
        private List<Fatura> faturas = new List<Fatura>();

        public void InserirFatura(Fatura fatura)
        {
            faturas.Add(fatura);
        }

        public void AlterarFatura(Fatura fatura)
        {
            var index = faturas.FindIndex(q => q.IDFatura == fatura.IDFatura);
            if (index != -1)
            {
                faturas[index] = fatura;
            }
        }

        public void RemoverFatura(Fatura fatura)
        {
            faturas.Remove(fatura);
        }


        public List<Fatura> ListaFatura(int idFatura)
        {
            return faturas.Where(r => r.IDFatura == idFatura).ToList();
        }
    }
}
