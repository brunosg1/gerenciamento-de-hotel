using Projeto_UML.Class;
using Projeto_UML.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Repositorio
{
    public class RepositorioQuarto : IRepositorioQuarto
    {
        private List<Quarto> quartos = new List<Quarto>();

        public void InserirQuarto(Quarto quarto)
        {
            quartos.Add(quarto);
        }

        public void AlterarQuarto(Quarto quarto)
        {
            var index = quartos.FindIndex(q => q.NumeroID == quarto.NumeroID);
            if (index != -1)
            {
                quartos[index] = quarto;
            }
        }

        public void RemoverQuarto(Quarto quarto)
        {
            quartos.Remove(quarto);
        }

        public Quarto ObterQuarto(int numero)
        {
            return quartos.FirstOrDefault(q => q.NumeroID == numero);
        }

        public List<Quarto> ListaQuarto()
        {
            return quartos;
        }
    }

}
