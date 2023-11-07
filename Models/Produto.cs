using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{
    public class Produto
    {

        private string nomeProduto;
        private int quantidadeProduto;
        private decimal valorUnitario;
        private decimal valorCompra;
        private int quantidadePedido;


        public Produto(string nomeProduto, int quantidadeProduto, decimal valorUnitario, 
        decimal valorCompra, int quantidadePedido){

        this.nomeProduto=nomeProduto;
        this.quantidadeProduto=quantidadeProduto;
        this.valorUnitario=valorUnitario;
        this.valorCompra=valorCompra;
        this.quantidadePedido=quantidadePedido;



        }

        public string getNomeProduto{
            get{return nomeProduto;}
        }
        public string setNomeProduto{
            set{nomeProduto=value;}
        }
        public int getQuantidadeProduto{
            get{return quantidadeProduto;}
        }
        public int setQuantidadeProduto{
            set{quantidadeProduto=value;}
        }
        public decimal getValorUnitario{
            get{return valorUnitario;}
        }
        public decimal setValorUnitario{
            set{valorUnitario=value;}
        }
        public decimal getValorCompra{
            get{return valorCompra;}
        }
        public decimal setValorCompra{
            set{valorCompra=value;}
        }
        public int getQuantidadePedido{
            get{return quantidadePedido;}
        }
        public int setQuantidadePedido{
            set{quantidadePedido=value;}
        }

        public void  comprar(){

            if(quantidadePedido <= quantidadeProduto & quantidadePedido > 0){
                valorCompra = valorUnitario * quantidadePedido;
                Console.WriteLine($"Produto:{nomeProduto}");
                Console.WriteLine($"Quantidade em estoque:{quantidadeProduto}");
                Console.WriteLine($"Preço Unitário:{valorUnitario}");
                Console.WriteLine($"Quantidade do produto no pedido:{quantidadePedido}");
                Console.WriteLine($"Valor total da compra:{valorCompra}");
                
            }else if(quantidadePedido <= 0){
                Console.WriteLine($"A quantidade do produto no pedido não pode ser igual ou menor a 0");
                Console.WriteLine("Compra não realizada");


            }else{
                Console.WriteLine($"Estoque insuficiente para a compra");
            }
        }
    }
}