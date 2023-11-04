﻿using Projeto_.NET.Models;

//criação do objeto pessoa
Pessoa pessoa = new Pessoa("", 0, 0, 0, 0);

DateTime dataHoraAtual = DateTime.Now.AddDays(5);

pessoa.setNome="João";
pessoa.setIdade=28;
pessoa.setAltura=1.70;
pessoa.setSalario=3500M;
pessoa.setCpf= Convert.ToInt32("11111111"); //Convertendo   tipo de variável

//adição de nova linha output
Console.WriteLine($"Olá, meu nome é {pessoa.getNome}, tenho {pessoa.getIdade} anos e");
Console.WriteLine($"minha altura é {pessoa.getAltura.ToString("0.00")} cm. Meu salário é R$ {pessoa.getSalario}");
Console.WriteLine($"Data e hora do output: {dataHoraAtual}");
Console.WriteLine($"CPF:{pessoa.getCpf}");


