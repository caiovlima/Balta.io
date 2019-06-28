using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Contracts
{
    public interface ICustomerRepository
    {
        void Save(string name);
    }
}
