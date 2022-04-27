using System;
using System.Collections.Generic; 

namespace Lanchonete
{
    public class Comanda
    {
        private int codigo;
        private string mensagem;
        private string nomeFantasia;
        private string cnpj;
        private string logradouro;
        private string telefone;
        private int loja;
        DateTime thisDay = DateTime.Today;
        private List<Produto> produtos = new List<Produto>();
        private List<Servico> Servicos = new List<Servico>();
        
        
        public Comanda(int cod, string mensagem, string nomeFantasia,string cnpj, string logradouro, string telefone, int loja)
        {
            this.Codigo = cod;
            this.Mensagem = mensagem;
            this.NomeFantasia = nomeFantasia;
            this.CNPJ = cnpj;
            this.Logradouro = logradouro;
            this.Telefone = telefone;
            this.Loja = loja;
       
        }
       

        public string NomeFantasia
        {
            get => this.nomeFantasia;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na tipo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do nomeFantasia");

                this.nomeFantasia = value;
            }
        }
        public string CNPJ
        {
            get => this.cnpj;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na tipo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do CNPJ");

                this.cnpj = value;
            }
        }
        public string Logradouro
        {
            get => this.logradouro;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na tipo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do logradouro");

                this.logradouro = value;
            }
        }
        public string Telefone
        {
            get => this.telefone;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na tipo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do Telefone");

                this.telefone = value;
            }
        }
        public string Mensagem
        {
            get => this.mensagem;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na tipo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do tipo");

                this.mensagem = value;
            }
        }
        public int Codigo
        {
            get => this.codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("Os parametros passado no código são invalido\n\n" +
                         "Informe Código que sejá maior e diferente de zero '0'");

                this.codigo = value;
            }
        }
        public int Loja
        {
            get => this.loja;
            set
            {
                if (value <= 0)
                    throw new Exception("Os parametros passado no código da Loja são invalido\n\n" +
                         "Informe código da Loja que sejá maior e diferente de zero '0'");

                this.loja = value;
            }
        }
        public override string ToString()
        {
            return 
            "\n_____________________________________________________________ \n"+
            this.NomeFantasia+"\n"+
            this.Logradouro+"\n"+
            "CNPJ: "+this.CNPJ+"\n"+
            "TELEFONE: "+this.Telefone+"\n"+
            "LOJA: "+this.Loja+"\n"+
            this.Mensagem +"\n"+
            "Comanda: "+this.Codigo+"\t\t DATA:    "+thisDay.ToString("G") ;
        }

    }
}