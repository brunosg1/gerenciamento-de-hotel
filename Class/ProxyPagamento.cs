using Projeto_UML.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Class
{
    public class ProxyPagamento : IPagamento
    {
        public IPagamento Servico { get; set; }

        public void Creditar(float valor)
        {
            throw new NotImplementedException();
        }

        public bool Debitar(float valor)
        {
            throw new NotImplementedException();
        }

        public bool Validar()
        {
            throw new NotImplementedException();
        }

        void SetMeioDePagamento(IPagamento meioPagamento)
        {
            throw new NotImplementedException();
        }
    }
}
