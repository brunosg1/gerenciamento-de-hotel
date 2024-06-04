using Projeto_UML.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Repositorio
{
    public class RepositorioServico
    {
        private List<Servico> servicos = new List<Servico>();

        public void InserirServico(Servico servico)
        {
            servicos.Add(servico);
        }

        public void AlterarServico(Servico servico)
        {
            var index = servicos.FindIndex(s => s.IdServico == servico.IdServico);
            if (index != -1)
            {
                servicos[index] = servico;
            }
        }

        public void RemoverServico(Servico servico)
        {
            servicos.Remove(servico);
        }

        public List<Servico> ListaServico()
        {
            return servicos;
        }
    }
}
