using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{
    public class ExemploCalculadora
    {

        private double valor1;
        private double valor2;
        private double resultado;

        public ExemploCalculadora(double valor1, double valor2, double resultado){

            this.valor1=valor1;
            this.valor2=valor2;
            this.resultado=resultado;

        }
        public double getValor1{
            get{return valor1;}
        }
        public double setValor1{
            set{valor1=value;}
        }
        public double getValor2{
            get{return valor2;}
        }
        public double setValor2{
            set{valor2=value;}
        }
        public double getResultado{
            get{return resultado;}
        }
        public double setResultado{
            set{resultado=value;}
        }

        public void somar(){
            resultado = valor1 + valor2;
        }
        public void dividir(){
            resultado = valor1 / valor2;
        }
        public void subtrair(){
            resultado = valor1 - valor2;
        }
        public void multiplicar(){
            resultado = valor1 * valor2;
        }
        public void restoDaDivisao(){
            resultado = valor1 % valor2;
        }
        public void potencia(){
            resultado = Math.Pow(valor1, valor2);
        }


        
        
    }
}