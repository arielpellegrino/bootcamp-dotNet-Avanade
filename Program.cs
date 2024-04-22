using System.Security.AccessControl;
using Dotnet_Avanade.Models;



int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEmEstoque > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"É possível realizar a velsnda? {possivelVenda}");

if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda Realizada");
}

else if(possivelVenda){
    Console.WriteLine("Venda inválida");
}

else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
}







// DateTime dataAtual = DateTime.Now;
// DateTime dataAtual2 = DateTime.Now.AddDays(2);
// DateTime dataAtual3 = DateTime.Now.AddDays(2);

// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual2);
// Console.WriteLine(dataAtual3.ToString("MM/dd/yyyy"));

//int a = Convert.ToInt32(null);
//int b = int.Parse("null");

// Console.WriteLine(a);
//Console.WriteLine(b);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Ariel";
// pessoa1.Idade = 31;
// pessoa1.Apresentar();

 //Pessoa pessoalFisicaRepresentacao = new Pessoa();

// int quantidade = 1;
// double altura = 1.55;

// decimal preco = 1.80M;
// bool condicion = true;

// Console.WriteLine(quantidade);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(preco);
// Console.WriteLine(condicion);