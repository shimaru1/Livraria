using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Livraria
{
    class ControlCompra
    {
        Compra compra;//conectando a model e a control
        private int opcao;



        public ControlCompra()
        {
            compra = new Compra();
        }//fim do construtor



        public void ExecutarCompra()
        {
            Console.WriteLine("Nome do Titular: ");
            string ModificarNomeCartao = Console.ReadLine();
            Console.WriteLine("Número do cartão: ");
            int ModificarNumeroCartao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Validade: ");
            DateTime ModificarValidadeCartao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Código CVC: ");
            int ModificarCodigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escolha a quantidade de parcelas: ");
            int ModificarParcela = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CPF do Titular: ");
            int ModificarCpf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Telefone do titular: ");
            string ModificarTelefoneCartao = Console.ReadLine();
        }//fim do metodo executar compra
    }//fim da classe
}//fim do projeto