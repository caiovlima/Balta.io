using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Repository
{
    public interface IFornecedorRepository
    {
        void Salvar(Fornecedor fornecedor);
    }
}
