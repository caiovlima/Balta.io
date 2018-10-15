using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP
{
    public class PessoaFisica: Pessoa
    {
        public PessoaFisica(string name, string cpf)
            :base(name)
        {
            Cpf = cpf;
        }
        public string Cpf { get; set; }
    }
}
