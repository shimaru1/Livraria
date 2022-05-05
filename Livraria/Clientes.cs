
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Clientes
    {
        //declararando as variáveis
        private int codigo;
        private string nomeCompleto;
        private string telefone;
        private string endereco;
        private DateTime dataDeNasc;
        private string nomeDeUser;
        private string senha;
        private string cartao;
        private string cds;

        //instanciando as variáveis (get & set)
        public Clientes()
        {
            ModificarCodigo = 0;
            ModificarNome = "";
            ModificarTelefone = "";
            ModificarEndereco = "";
            ModificarDataDeNasc = new DateTime();
            ModificarUsuario = "";
            ModificarSenha = "";
            Modificarcartao = "";
            Modificarcds = "";

        }//fim do método construtor



        //desenvolvendo métodos gets e sets
        public int ModificarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//fim do método ModificarCodigo



        public string ModificarNome
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                this.nomeCompleto = value;
            }
        }//fim do método ModificarNomeCompleto



        public string ModificarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do método ModificarTelefone



        public string ModificarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }
        }//fim do método ModificarEndereco



        public DateTime ModificarDataDeNasc
        {
            get
            {
                return dataDeNasc;
            }
            set
            {
                this.dataDeNasc = value;
            }
        }// fim do metodo modiaifha



        public string ModificarUsuario
        {
            get
            {
                return nomeDeUser;
            }
            set
            {
                this.nomeDeUser = value;
            }
        }



        public string ModificarSenha
        {
            get
            {
                return senha;
            }
            set
            {
                this.senha = value;
            }
        }

        public string Modificarcartao
        {
            get
            {
                return  cartao;
            }
            set
            {
                this.cartao = value;
            }
        }

        public string Modificarcds
        {
            get
            {
                return cds;
            }
            set
            {
                this.cds = value;
            }
        }


        public void Cadastrar(int codigo, string nome,
                              string telefone, string endereco, DateTime dataDeNasc, string usuario, string senha)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarTelefone = telefone;
            ModificarEndereco = endereco;
            ModificarDataDeNasc = dataDeNasc;
            ModificarUsuario = usuario;
            ModificarSenha = senha;
        }//fim do método cadastrar



        public string Consultar(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                return "Código: " + ModificarCodigo + "\nNome completo: " + ModificarNome +
                "\nData de Nascimento: " + ModificarDataDeNasc + "\nTelefone: " + ModificarTelefone +
                "\nEndereço: " + ModificarEndereco + "\nNome de Usuário: " + ModificarUsuario;
            }
            else
            {
                return "Código informado não é válido!";
            }//fim do if/else
        }//fim do método consular



        public string AtualizarNome(int codigo, string nome)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarNome = nome;
                return "Nome atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método alterar



        public string AtualizarTelefone(int codigo, string telefone)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarTelefone = telefone;
                return "Telefone atualizado com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do método atualizarTelefone



        public string AtualizarEndereco(int codigo, string endereco)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarEndereco = endereco;
                return "Endereço atualizado com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do método atualizarEndereco



        public string AtualizarDataDeNasc(int codigo, DateTime dataDeNasc)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarDataDeNasc = dataDeNasc;
                return "Data de nascimento atualizada com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do metodo atualizarDataDeNascimeto



        public string AtualizarUsuario(int codigo, string usuario)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarUsuario = usuario;
                return "Nome de usuário atualizada com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do metodo atualizarUsuario

        public string AtualizarSenha(int codigo, string senha)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarSenha = senha;
                return "Nome de senha atualizada com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do metodo atualizarUsuario

        public string AtualizarNumeroDoCartao(int codigo, string numeroDoCart)
        {
            if (ModificarCodigo == codigo)
            {
                Modificarcartao = numeroDoCart;
                return "Numero do seu cartão atualizada com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do metodo atualizarUsuario

        public string AtualizarCDS(int codigo, string CDS)
        {
            if (ModificarCodigo == codigo)
            {
                Modificarcds = CDS;
                return "O codigo de segurança atualizada com sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do metodo atualizarUsuario


        public string Excluir(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarCodigo = 0;
                ModificarNome = "";
                ModificarTelefone = "";
                ModificarEndereco = "";
                ModificarUsuario = "";
                ModificarSenha = "";
                ModificarDataDeNasc = new DateTime();
                return "Dados excluidos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir





    }
}
