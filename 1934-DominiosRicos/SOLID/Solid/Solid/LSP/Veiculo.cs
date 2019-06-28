using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP
{
    public abstract class Veiculo
    {
        public virtual void LigarMotor() {
            Console.WriteLine("Ligou o motor (PAI)");
        }

        public void Acelerar() {
            Console.WriteLine("Acelerou (PAI)");
        }
    }
}
