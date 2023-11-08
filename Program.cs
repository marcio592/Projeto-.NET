using Projeto_.NET.Models;
/*
//criação do objeto pessoa
Pessoa pessoa = new Pessoa("", 0, 0, 0, 0, "");

DateTime dataHoraAtual = DateTime.Now.AddDays(5);

pessoa.setNome="João";
pessoa.setIdade=28;
pessoa.setAltura=1.70;
pessoa.setSalario=3500M;
pessoa.setCpf= Convert.ToInt32("11111111"); 
pessoa.setCep=Convert.ToString(111111);

//adição de nova linha output
Console.WriteLine($"Olá, meu nome é {pessoa.getNome}, tenho {pessoa.getIdade} anos e");
Console.WriteLine($"minha altura é {pessoa.getAltura.ToString("0.00")} cm. Meu salário é R$ {pessoa.getSalario}");
Console.WriteLine($"Data e hora do output: {dataHoraAtual}");
Console.WriteLine($"CPF:{pessoa.getCpf}");
Console.WriteLine($"Cep:{pessoa.getCep}");
*/
/*
Produto produto = new Produto("", 0, 0, 
        0, 0);

        produto.setNomeProduto="Livro";
        produto.setQuantidadeProduto=10;
        produto.setValorUnitario=20.00m;
        produto.setQuantidadePedido=-1;


        produto.comprar();
        


Console.WriteLine("Digite uma vogal:");
string letra = Console.ReadLine();

switch(letra){
        case "a":
        case "e":
        case "i":
        case "o":
        case "u":
        Console.WriteLine("Vogal");
        break;

        default:
        Console.WriteLine("Consoante");
        break;

}



bool maiorDeIdade=true;
bool autorizacaoDoResponsavel=false;

if(maiorDeIdade || autorizacaoDoResponsavel ){
        Console.WriteLine("Entrada liberada");



}else{
        Console.WriteLine("Entrada não liberada");
}

*/

Discente discente = new Discente("", "", 0, 0, 0, 0, 0);

discente.setNome="Tiago";
discente.setCurso="Sistemas de informação";
discente.setMatricula=111111;
discente.setNota1=8.00;
discente.setNota2=7.00;
discente.setFrequencia=65;

discente.calcularMedia();

if(discente.getMedia >=7.00 &&  discente.getFrequencia >= 75){
        Console.WriteLine($"Discente:{discente.getNome}");
        Console.WriteLine($"Curso:{discente.getCurso}");
        Console.WriteLine($"Matrícula:{discente.getMatricula}");
        Console.WriteLine($"Avalisação1:{discente.getNota1}");
        Console.WriteLine($"Avaliação2:{discente.getNota2}");
        Console.WriteLine($"APROVADO MÉDIA:{discente.getMedia} e Frequência:{discente.getFrequencia}%");


}
//else central
else if(discente.getMedia < 7.00 && discente.getFrequencia < 75){
        Console.WriteLine($"Discente:{discente.getNome}");
        Console.WriteLine($"Curso:{discente.getCurso}");
        Console.WriteLine($"Matrícula:{discente.getMatricula}");
        Console.WriteLine($"Avalisação1:{discente.getNota1}");
        Console.WriteLine($"Avaliação2:{discente.getNota2}");
        Console.WriteLine($"REPROVADO MÉDIA:{discente.getMedia} e Frequência:{discente.getFrequencia}%");
}

else if(discente.getMedia <= 7.00 || discente.getFrequencia < 75){
        if(discente.getMedia <= 7.00){

        Console.WriteLine($"Discente:{discente.getNome}");
        Console.WriteLine($"Curso:{discente.getCurso}");
        Console.WriteLine($"Matrícula:{discente.getMatricula}");
        Console.WriteLine($"Avalisação1:{discente.getNota1}");
        Console.WriteLine($"Avaliação2:{discente.getNota2}");
        Console.WriteLine($"Frequência:{discente.getFrequencia}%");
        Console.WriteLine($"REPROVADO MÉDIA:{discente.getMedia}");
        }else{
        Console.WriteLine($"Discente:{discente.getNome}");
        Console.WriteLine($"Curso:{discente.getCurso}");
        Console.WriteLine($"Matrícula:{discente.getMatricula}");
        Console.WriteLine($"Avaliação1:{discente.getNota1}");
        Console.WriteLine($"Avaliação2:{discente.getNota2}");
        Console.WriteLine($"Média:{discente.getMedia}");
        Console.WriteLine($"REPROVADO FREQUÊNCIA:{discente.getFrequencia}%");
        }
        }



