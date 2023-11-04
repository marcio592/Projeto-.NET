using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{
    public class Pessoa
    {
        private String nome;
        private int idade;
        private double altura;
        private decimal salario;

        public Pessoa(String nome, int idade , double altura, decimal salario)
        {
            this.nome=nome;
            this.idade=idade;
            this.altura=altura;
            this.salario=salario;


        }
        public string getNome{
          get{return nome;}


        }
        public string setNome{
         set{nome=value;}
        }
        public int getIdade{
            get{return idade;}

        }
        public int setIdade{
            set{idade=value;}
        }
        public double getAltura{
            get{return altura;}
        }
        public double setAltura{
            set{altura=value;}
        }
        public decimal getSalario{
            get{return salario;}
        }
        public decimal setSalario{
            set{salario=value;}
        }

        
        
    }
}