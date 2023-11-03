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

        public Pessoa(String nome, int idade)
        {
            this.nome=nome;
            this.idade=idade;


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

        
        
    }
}