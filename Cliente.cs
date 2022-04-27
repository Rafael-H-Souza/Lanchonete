using System;

namespace Lanchonete
{
    public class Cliente
    {
        private int codigo;
        private string nome;
        private string cpf;
        private string telefone;

        
        public Cliente( int codigo, string nome , string cpf, string telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
        }
        public int Codigo
        {
            get => this.codigo;
            set
            {
                if(value < 0)
                    throw new Exception("Código invalido");
                
                this.codigo = value;
            }
        }
        public string Nome
        {
            get => this.nome;
            set
            {
                if(value == null || value.Trim().Length == 0)
                    throw new Exception("Nome do Cliente é invalido");
                
                this.nome = value;
            }
        }
        public string CPF
        {
            get => this.cpf;
            set
            {
                if(value == null || value.Trim().Length == 0)
                    throw new Exception("Nome do Cliente é invalido");
                
                this.cpf = value;
            }
        }
        public string Telefone
        {
            get => this.telefone;
            set
            {
                if(value == null || value.Trim().Length == 0)
                    throw new Exception("Nome do Cliente é invalido");
                
                this.telefone = value;
            }
        }
        public override string ToString()
        {
            return "\nCódigo: "+this.Codigo +"\t\t\tCliente: " +this.Nome+"\n"+
            "CPF: "+this.CPF+"\t\tTelefone: "+ this.Telefone;
        }
    }
}