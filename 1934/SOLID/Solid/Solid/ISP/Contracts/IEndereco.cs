using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Contracts
{
    public interface IEndereco
    {
         string Cidade { get; set; }
         string Estado { get; set; }
         string Pais { get; set; }
    }
}
