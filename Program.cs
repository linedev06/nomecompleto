// See https://aka.ms/new-console-template for more information
Console.Write("Qual é o seu nome?");
string nome = Console.ReadLine()!;

Console.Write("Qual é o seu sobrenome?");
string sobrenome = Console.ReadLine()!;

Console.WriteLine(    $"boa noite, {nome} {sobrenome}");