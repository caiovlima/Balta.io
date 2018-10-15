using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    public class Pessoa
    {
        public Pessoa(string name)
        {
            if (name.Length < 3)
            {
                throw new Exception("Nome inválido");
            }
            Name = name;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            if (name.Length < 3)
            {
                throw new Exception("Nome inválido");
            }
            Name = name;
        }
    }
}
