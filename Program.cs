using Projeto_.NET.Models;

//criação do objeto pessoa
Pessoa pessoa = new Pessoa("", 0, 0, 0);

pessoa.setNome="João";
pessoa.setIdade=28;
pessoa.setAltura=1.70;
pessoa.setSalario=3500M;

//adição de nova linha output
Console.WriteLine($"Olá, meu nome é {pessoa.getNome}, tenho {pessoa.getIdade} anos e");
Console.WriteLine($"minha altura é {pessoa.getAltura.ToString("0.00")} cm. Meu salário é R$ {pessoa.getSalario}");


