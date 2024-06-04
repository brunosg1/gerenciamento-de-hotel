using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UML.Interface
{
    public interface IPagamento
    {
        bool Validar();
        void Creditar(float valor);
        bool Debitar(float valor);
    }
}
