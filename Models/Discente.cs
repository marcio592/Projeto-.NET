using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_.NET.Models
{
    public class Discente
    {
        private string nome;
        private string curso;
        private int matricula;
        private double nota1;
        private double nota2;
        private double media;
        private int frequencia;

        public Discente(string nome, string curso, int matricula, double nota1,
        double nota2, double media, int frequencia ){

            this.nome=nome;
            this.curso=curso;
            this.matricula=matricula;
            this.nota1=nota1;
            this.nota2=nota2;
            this.media=media;
            this.frequencia=frequencia;

        }
        public string getNome{
            get{return nome;}
        }
        public string setNome{
            set{nome=value;}
        }
        public string getCurso{
            get{return curso;}
        }
        public string setCurso{
            set{curso=value;}
        }
        public int getMatricula{
            get{return matricula;}
        }
        public int setMatricula{
            set{matricula=value;}
        }
        public double getNota1{
            get{return nota1;}
        }
        public double setNota1{
            set{nota1=value;}
        }
        public double getNota2{
            get{return nota2;}
        }
        public double setNota2{
            set{nota2=value;}
        }
        public double getMedia{
            get{return media;}
        }
        public double setMedia{
            set{media=value;}
        }
        public int getFrequencia{
            get{return frequencia;}
        }
        public int setFrequencia{
            set{frequencia=value;}
        }

        public void calcularMedia(){
            media=(nota1 + nota2) /2;

        }

    }
}