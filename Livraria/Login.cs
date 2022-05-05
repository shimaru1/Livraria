using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Livraria
    {
    
        class Login
        {

            Clientes clientes;

            public Login()
            {
                clientes = new Clientes();
            }

            public string LogginIn(string usuario, string senha)
            {


                do
                {
                    Console.WriteLine("Digite seu nome de usuário");
                    Console.WriteLine("Digite sua senha: ");
                    if (senha != clientes.ModificarSenha)
                    {
                        Console.WriteLine("Senha incorreta! Tente novamente.");
                    }
                } while (senha != clientes.ModificarSenha);



                return "Bem vindo," +  "!";
            }
        }//fim da classe
    }//fim do projeto

