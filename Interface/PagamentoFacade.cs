using Projeto_UML.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Interface
{
    public interface PagamentoFacade
    {
        bool VerificacaoPagamento(ProxyPagamento proxyPagamento);
    }
}
