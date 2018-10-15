using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP.Contracts
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Save(string name)
        {
            Console.WriteLine(name);
        }
    }
}
