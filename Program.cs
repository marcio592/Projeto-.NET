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

/*

Discente discente = new Discente("", "", 0, 0, 0, 0, 0);

discente.setNome="Tiago";
discente.setCurso="Sistemas de informação";
discente.setMatricula=111111;
discente.setNota1=8.00;
discente.setNota2=7.00;
discente.setFrequencia=75;

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

else{
        if(discente.getMedia < 7.00){

        Console.WriteLine($"Discente:{discente.getNome}");
        Console.WriteLine($"Curso:{discente.getCurso}");
        Console.WriteLine($"Matrícula:{discente.getMatricula}");
        Console.WriteLine($"Avalisação1:{discente.getNota1}");
        Console.WriteLine($"Avaliação2:{discente.getNota2}");
        Console.WriteLine($"Frequência:{discente.getFrequencia}%");
        Console.WriteLine($"REPROVADO MÉDIA:{discente.getMedia}");
        }else if(discente.getFrequencia < 75){
        Console.WriteLine($"Discente:{discente.getNome}");
        Console.WriteLine($"Curso:{discente.getCurso}");
        Console.WriteLine($"Matrícula:{discente.getMatricula}");
        Console.WriteLine($"Avaliação1:{discente.getNota1}");
        Console.WriteLine($"Avaliação2:{discente.getNota2}");
        Console.WriteLine($"Média:{discente.getMedia}");
        Console.WriteLine($"REPROVADO FREQUÊNCIA:{discente.getFrequencia}%");
        }
        }

*/

/*
bool choveu=true;
bool estarTarde=true;

if(!choveu && !estarTarde){
        Console.WriteLine("Não vou pedalar");

}else{
        Console.WriteLine("Vou pedalar");
}
*/

/*
ExemploCalculadora calculadora =  new ExemploCalculadora(0, 0, 0, 0);

calculadora.setValor1=3.00;
calculadora.setValor2=3.00;

calculadora.setAngulo=30;

calculadora.potencia();

Console.WriteLine($"Potência: {calculadora.getResultado}");

calculadora.seno();
calculadora.coseno();
calculadora.tangente();
calculadora.raizQuadrada();

*/

/*
int numero = 5;

for(int cont=0; cont <= 10; cont++){
        Console.WriteLine($"{numero} x {cont} = {numero * cont}");
}
*/

/*
int numero=5;
int cont=0;

while(cont <= 10){
        Console.WriteLine($"{numero} * {cont} ={numero * cont}");
        cont++;

        if(cont == 6){
                break;
        }

}

*/

/*
int soma=0;
int numero=0;

do{
        Console.WriteLine("Digite um número para somar(0 para parar!):");
        numero = Convert.ToInt32(Console.ReadLine());
        soma += numero;

}while(numero != 0);
Console.WriteLine($"Resultado da soma:{soma}");

*/

/*
int opcao;
bool exibirMenu=true;

while(exibirMenu){
        
        Console.WriteLine("1 - Cadastrar cliente");
        Console.WriteLine("2 - Consultar cliente");
        Console.WriteLine("3 - Excluir cliente");
        Console.WriteLine("4 - Encerrar");
        Console.WriteLine("Digite a opção desejada:");

        opcao = Convert.ToInt32(Console.ReadLine());

        switch(opcao){
                case 1:
                Console.WriteLine("Cadastro de clientes");
                break;
                case 2:
                Console.WriteLine("Consulta de clientes");
                break;
                case 3:
                Console.WriteLine("Excluir cliente");
                break;
                case 4:
                Console.WriteLine("Encerrar");
                //Environment.Exit(0);
                exibirMenu = false;
                break;

                default:
                Console.WriteLine("Opção inválida");
                break;

        }
}

Console.WriteLine("Programa encerrado");

*/

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 62;
arrayInteiros[1] = 87;
arrayInteiros[2] = 588;
arrayInteiros[3] = 777;

for(int cont=0; cont < arrayInteiros.Length; cont++){
        Console.WriteLine($"Posição {cont} = {arrayInteiros[cont]}");
}

Console.WriteLine("Exemplo de foreach");
int contadorForeach=0;

foreach(int valor in arrayInteiros){
         Console.WriteLine($"Posição {contadorForeach} = {valor}");
         contadorForeach++;

}
