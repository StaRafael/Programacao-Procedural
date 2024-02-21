using System;
using System.Reflection.Metadata;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a nota 1: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota 2: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota 3: ");
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota 4: ");
    double nota4 = double.Parse(Console.ReadLine());

    double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

    Console.WriteLine("A media do aluno eh:" + media);

  }
}