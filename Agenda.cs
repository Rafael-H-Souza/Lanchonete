using System;

namespace Lanchonete 
{
    class Agenda
    {
        private int  hora ;
        private int minuto;
        private int dia;
        private int mes;
        private int ano;
        private string titulo;// -- teste 
        private string mensagem;// -- teste
        private int tempoAlocado;//-- teste 
        private Cliente cliente ;
        
        
        public Agenda(int dia, int mes, int ano,int hora, int minuto, string titulo,string  mensagem)
        {
            this.Dia = dia;
            this.Mes = mes;
            this.Ano = ano;
            this.Hora= hora;
            this.Minuto = minuto;
            this.Titulo = titulo;
            this.Mensagem = mensagem;
    
        }

        public void addClienete(Cliente cliente)
        {
             this.cliente = cliente;            
        }
        public int Hora
        {
            get => this.hora;
            set
            {
                if(value < -1 || value>61)
                    throw new Exception("Horario invalido");

                this.hora = value;
            }
        }
        public int Minuto
        {
            get => this.minuto;
            set
            {
                if(value < -1 || value>61)
                    throw new Exception("Minuto invalido");

                this.minuto = value;
            }
        }
        public int Dia
        {
            get => this.dia;

            set
            {
                if(value < 0 || value > 32)
                    throw new Exception("Dia invalido");
                
                this.dia = value;

            }
        }
        public int Mes
        {
            get => this.mes;

            set
            {
                if(value < 0 || value > 13)
                    throw new Exception("Mes invalido");
                
                this.mes = value;        

            }
        }
        public int Ano
        {
            get => this.ano;

            set
            {
                if(value < 2000 || value > 3000)
                    throw new Exception("Ano invalido");
                
                this.ano = value;        

            }
        }
        public string Titulo
        {
            get => this.titulo;
            set
            {
                if(value == null || value.Trim().Length == 0)
                    throw new Exception("Os parametros passado para o titulo são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do titulo");

                this.titulo = value;
            }
        }
        public string Mensagem
        {
            get => this.mensagem;
            set 
            {
                if(value ==null || value.Trim().Length == 0)
                    throw new Exception("Os parametros passado para a Mensagem são invalido\n\n" +
                        "Informe um texto ou palavra para a validação do Mensagem");
                        
                this.mensagem = value;
            }
        }
        
        public override string ToString()
        {
            return 
            "\n_____________________________________________________________ \n"+               
            "\nData: "+this.Dia+"/"+this.Mes+"/"+this.Ano+"\tHorario: "+this.Hora+":"+this.Minuto+
            "\nTitulo: "+this.Titulo+"\nMensagem: "+this.Mensagem+"\n"+
            "\n_____________________________________________________________ \n";
        }
    }
}