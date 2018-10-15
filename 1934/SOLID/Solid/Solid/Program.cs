using Solid.DIP;
using Solid.DIP.Contracts;
using Solid.ISP;
using Solid.LSP;
using Solid.OCP;
using Solid.SRP;
using Solid.SRP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.ChangeName("Caio");

            IFornecedorRepository rep = new FornecedorRepository();
            rep.Salvar(fornecedor);
            #endregion

            #region OCP
            var p = new Pessoa("Caio");
            p.ChangeName("Caio");

            var pf = new PessoaFisica("Caio", "999.9999.9999-9");
            #endregion

            #region LSP
            var veiculo = new Carro();
            veiculo.LigarMotor();
            #endregion
                      
            #region ISP
            NotaFiscal nf = new NotaFiscal();
            nf.RealizarPedido();

            #endregion

            #region DIP
            //var rep = new CustomerRepository();
            //var customerService = new CustomerService(rep);
            #endregion
            Console.ReadKey();

        }
    }
}
