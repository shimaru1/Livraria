using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class CartaoDeCredito
    {
        Clientes clientes;

        public CartaoDeCredito()
        {
            clientes = new Clientes();
        }

        public string CartãoDeCredito(string numeroDoCar, string codigoDeSeg)
        {


            do
            {
                Console.WriteLine("Digite o numero do Cartão ");
                Console.WriteLine("informe codigo de segurança: ");
                if (codigoDeSeg != clientes.)
                {
                    Console.WriteLine("Senha incorreta! Tente novamente.");
                }
            } while (codigoDeSeg != clientes.Modificarcartao);



            return "Bem vindo," + "!";
        }




    }
}
