using Dotnet_Avanade.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Ariel";
pessoa1.Idade = 31;
pessoa1.Apresentar();

//Pessoa pessoalFisicaRepresentacao = new Pessoa();

int quantidade = 1;
double altura = 1.55;

decimal preco = 1.80M;
bool condicion = true;

Console.WriteLine(quantidade);
Console.WriteLine(altura.ToString("0.00"));
Console.WriteLine(preco);
Console.WriteLine(condicion);