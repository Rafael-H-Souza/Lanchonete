
using System;
using System.Collections.Generic; 

namespace Lanchonete
{
    public class Servico
    {
        private int codigo;
        private string descricao;
        private string tipo;
        private string medida;
        private double quantidade;
        private double valor;
        private double tempo;
        
        private List<Servico> servicos = new List<Servico>();

        public Servico( int cod, string desc, string tipo, string medida, double qntds, double valor )
        {
            this.Codigo = cod;
            this.Descricao = desc;
            this.Tipo = tipo;
            this.Medida = medida;
            this.Quantidade = qntds;
            this.Valor = valor;
            
        }
        public void AddEmpenhoServico(Servico p)
        {
            this.servicos.Add(p);
        }
        public void RemoverEmpenhoServico(Servico p)
        {
            this.servicos.Remove(p);
        }
        public double Valor
        {
            get => this.valor;
            set
            {
                if (value <= 0)
                    throw new Exception("Os parametros passado para valor são invalido\n\n" +
                         "Informe valores que sejá maior e diferente de zero '0'");

                this.valor = value;
            }
        }
        public double Quantidade
        {
            get => this.quantidade;
            set
            {
                if (value <= 0)
                    throw new Exception("Os parametros passado para quantidade são invalido\n\n" +
                         "Informe valores que sejá maior e diferente de zero '0'");

                this.quantidade = value;
            }
        }

        public string Tipo
        {
            get => this.tipo;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na tipo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do tipo");

                this.tipo = value;
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
        public string Descricao
        {
            get => this.descricao;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na descrição são invalido\n\n" +
                        "Informe um texto ou palavra para a validação da descrição");

                this.descricao = value;
            }
        }
        public string Medida
        {
            get => this.medida;
            set
            {
                if (value == null || value.Trim().Length == 0)

                    throw new Exception("Os parametros passado na medida são invalido\n\n" +
                        "Informe um texto ou palavra para a validação da medida");

                this.medida = value;
            }
        }
        public double Tempo
        {
            get => this.tempo;
            set
            {
                if (value <= 0)
                    throw new Exception("Os parametros passado para o Tempo são invalido\n\n" +
                         "Informe valores que sejá maior e diferente de zero '0'");

                this.Tempo = value;
            }
        }

        
        public void ListarEmpenho()
        {       
             
            foreach(Servico value in servicos)
            {
                Console.WriteLine(value);
                
                foreach(Servico item in value.servicos)
                {
                    Console.WriteLine("\t{0}",item);
                }
            }
                
        }
        public void ValorEmpenho()
        {
            double num = 0;

            foreach(Servico value in servicos)
            {
               num+=value.Valor;
               foreach(Servico item in value.servicos)
               {
                   num+=item.Valor;
               }
            }               
            num += Valor;
            Console.WriteLine("\n\nValor total:\t\t\t\t\t\t\t\t {0}",num);
        }
        public override string ToString()
        {
            return "CÓDIGO: " + this.Codigo + "\t\tDESCRIÇÃO: " + this.Descricao +
                "\nTIPO: " + this.Tipo + "\t\t QUANT: " + this.Quantidade +"  "+ this.Medida +
                "\tVALOR: " + this.Valor+"\n" ;
        }

    
    }
}