using Projeto_.NET.Models;

//criação do objeto pessoa
Pessoa pessoa = new Pessoa("", 0);

pessoa.setNome="João";
pessoa.setIdade=28;

Console.WriteLine($"Olá, meu nome é {pessoa.getNome} e tenho {pessoa.getIdade} anos");


