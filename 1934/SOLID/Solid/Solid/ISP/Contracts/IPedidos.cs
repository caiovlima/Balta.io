using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Contracts
{
    public interface IPedidos
    {
        DateTime Data { get; set; }
        void RealizarPedido();
    }
}
