using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Livraria
{
    class Compra
    {
        Login login;
        private string nome;
        private int numero;
        private DateTime validade;
        private int codigo;
        private int parcela;
        private int cpf;
        private string telefone;



        public Compra()
        {
            login = new Login();
            ModificarNomeCartao = "";
            ModificarNumeroCartao = 0;
            ModificarValidadeCartao = new DateTime();
            ModificarCodigo = 0;
            ModificarParcela = 0;
            ModificarCpf = 0;
            ModificarTelefoneCartao = "";
        }



        public string ModificarNomeCartao
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }//fim do metodo modificarNomeCartao



        public int ModificarNumeroCartao
        {
            get
            {
                return numero;
            }
            set
            {
                this.numero = value;
            }
        }//fim do metodo modificar numero cartao



        public DateTime ModificarValidadeCartao
        {
            get
            {
                return validade;
            }
            set
            {
                this.validade = value;
            }
        }//fim do modificar validade



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
        }//fim do metodo modificar codigo



        public int ModificarParcela
        {
            get
            {
                return parcela;
            }
            set
            {
                this.parcela = value;
            }
        }//fim do metodo modificar parcela



        public int ModificarCpf
        {
            get
            {
                return cpf;
            }
            set
            {
                this.cpf = value;
            }
        }// fim do metodo modificar cpf



        public string ModificarTelefoneCartao
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do metodo modificar telefone



        public string Comprando(string nome, int numero, DateTime validade, int codigo, int parcela,
        int cpf, string telefone)
        {
            ModificarNomeCartao = nome;
            ModificarNumeroCartao = numero;
            ModificarValidadeCartao = validade;
            ModificarCodigo = codigo;
            ModificarParcela = parcela;
            ModificarCpf = cpf;
            ModificarTelefoneCartao = telefone;
            return ("Compra efetuada com sucesso!");
        }//fim do metodo comprando
    }//fim da classe
}//fim do projeto