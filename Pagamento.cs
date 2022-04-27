 using System;

 namespace Lanchonete
{
    public class Pagamento
    {
        private double valorTotal;
        private int  formaDePag;
        Boolean condic = false;
        private int comandaTeste;
        DateTime thisDay = DateTime.Today;
        public Pagamento(int comanda,double valorTotal )
        {
            this.comandaTeste = comanda;
            this.ValorTotal = valorTotal;
        }
        public double ValorTotal
        {
            get => this.valorTotal;
            set
            {
                if(value <= 0)
                    throw new Exception("Valores da compra não forão atribuido");
                this.valorTotal= value;
            }
        }
        private double calculojuros(int indice, double valorTotal, double taxa )
        {
            double taxaAux, valorParcela = 0;

            for(int i = 1; i <= indice ;i++)
            {
                valorParcela = (valorTotal/i);
                taxaAux = taxa* i;
                valorParcela += valorParcela *taxaAux;
            }
            return valorParcela;
        }
        public  void Parcela(double valorTotal)
        {
           
            double valorParcela = 0;
            int indice;
            
            do{
                for(int i = 1; i <= 12 ;i++)
                {
                    valorParcela=calculojuros(i,valorTotal, 0.0025);
                                        
                    Console.Out.WriteLine("Parcela {0}\t X   {1} =\t"+
                    "{2}",i,valorParcela.ToString("f"), ((i*valorParcela).ToString("f")));
            
                }
                Console.Out.Write("\nInforme em quantas parcela serão realizada a compra: ");
                indice = int.Parse(Console.ReadLine());
            }while(indice >0 && indice>13);

            valorParcela=calculojuros(indice,valorTotal, 0.0025);
            Console.WriteLine("Confirme os dados selecionados ");
            Console.Out.WriteLine("Parcela {0}\t X   {1} =\t"+
                    "{2}",indice,valorParcela.ToString("f"), ((indice*valorParcela).ToString("f")));
           
        }
        public void PagamentoCartao()
        {
            double valor = 0, troco;
            Boolean condicao = false ;

            condicao = this.condic;
            if(condicao == false)
            {
                Console.Out.WriteLine("O valor da Compra: {0}\n", this.ValorTotal);

                Console.Out.Write("Informe o valor recebido: ");
                valor = double.Parse(Console.ReadLine());
            }
            
            if(valor > this.ValorTotal)
            {
                troco = valor - this.ValorTotal;
                Console.Out.WriteLine("Troco a ser devolvido: {0}", troco);
                Console.Out.WriteLine("Pagamento efetuado com sucesso");
            }
            else if(valor == this.ValorTotal|| condicao == true)
            {
                Console.Out.WriteLine("Pagamento efetuado com sucesso");
            }
            else if(valor < this.ValorTotal)
            {
                this.ValorTotal =this.ValorTotal- valor;
                Console.Out.WriteLine("O valor restante  da compra: {0}\n", this.ValorTotal);

                this.FormaDePagamento();             
            }
           
        }
        public void CancelamentoDeCompra()
        {
            char opcaoL;
            Console.Out.WriteLine(" Cancelar Compra\n");
            Console.Out.WriteLine("Para cancelar a compra digite {S} para SIM\n"+
                "   caso queira retornar para a tela aterior digite {N} para NÃO");
            Console.Out.Write("Informe a Opção desejada: ");
            opcaoL = char.Parse(Console.ReadLine());

            if(opcaoL == 'S' || opcaoL =='s')
            {
                Console.Out.Write("-> Sim!\t");
                Console.Out.WriteLine("COMPRA CANCELADA COM SUCESSO!\n");                      
            }
            else if(opcaoL == 'N' || opcaoL =='n')
            {
                Console.Clear();
                Console.Out.Write("-> Não\n");
                FormaDePagamento();
            }
        }
        public void PagamentoPix()
        {
            Console.Out.WriteLine("Forma de Pagamento PIX\n");
            Console.Out.WriteLine("Chave: 11945687458{0}{1}{2}",this.comandaTeste,this.ValorTotal,this.thisDay.ToString("d"));
            
            Console.Out.WriteLine("Pagamento efetuado com sucesso");
        }
        public int FormaDePagamento()
        {
            byte opcao;
            
            //string conceito;
            Console.Out.WriteLine("Forma de Pagamento\n");
            Console.Out.WriteLine("Informe a forma de pagamento\n");
            Console.Out.WriteLine("1-) Pagamento em Dinheiro");
            Console.Out.WriteLine("2-) Pagamento com Pix");
            Console.Out.WriteLine("3-) Pagamento em Cartão de Debito ");
            Console.Out.WriteLine("4-) Pagamento em Cartão de Credito ");
            Console.Out.WriteLine("5-) Pagamento em Cartão de Alimentação ");
            Console.Out.WriteLine("6-) Pagamento em Cartão de Refeição ");
            Console.Out.WriteLine("0-) Cancelar Compra");
            Console.Out.Write("\nInforme a Opcão desejada: ");
            opcao = byte.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 0: 
                    CancelamentoDeCompra();
                        break;
                case 1:
                    PagamentoCartao();
                        break;
                case 2:
                   PagamentoPix();
                        break;
                case 3:
                    PagamentoCartao();
                        break;
                case 4:
                    Parcela(this.valorTotal);
                    this.condic = true;
                    PagamentoCartao();
                        break;
                case 5:
                    PagamentoCartao();
                        break;
                case 6:
                    PagamentoCartao();
                        break;
                default:
                    
                    Console.Out.Write("\nA forma de pagamento não foi indentificada "+
                        "Por favor, selecione novamente!\n");
                    Console.Out.Write("Precione <<Enter>> para prosseguir ");
                    while(Console.ReadKey().Key != ConsoleKey.Enter){}
                    FormaDePagamento();
                break;
                    
                        
            }

            return 0;
        }
        public override string ToString()
        {
            return  "\nComanda: "+this.comandaTeste+"\tValor Total: "+this.ValorTotal;
        }
    }
}
