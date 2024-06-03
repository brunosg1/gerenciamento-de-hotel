using Projeto_UML.Class;
using Projeto_UML.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Repositorio
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void Inserir(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public void Atualizar(Pessoa pessoa)
        {
            var index = pessoas.FindIndex(p => p.Id == pessoa.Id);
            if (index != -1)
            {
                pessoas[index] = pessoa;
            }
        }

        public void Excluir(Pessoa pessoa)
        {
            pessoas.Remove(pessoa);
        }

        public Pessoa ObterPorId(int id)
        {
            return pessoas.FirstOrDefault(p => p.Id == id);
        }

        public List<Pessoa> ObterTodos()
        {
            return pessoas;
        }
    }
}
