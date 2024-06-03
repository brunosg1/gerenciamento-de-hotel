using Projeto_UML.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Interface
{
    public interface IRepositorioPessoa
    {
        void Inserir(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        void Excluir(Pessoa pessoa);
        Pessoa ObterPorId(int id);
        List<Pessoa> ObterTodos();
    }
}
