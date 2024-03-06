using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a nota da prova 1.");
    double prova1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da prova 2.");
    double prova2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da prova 3.");
    double prova3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da prova 4.");
    double prova4 = double.Parse(Console.ReadLine());

    double media = (prova1 + prova2 + prova3 + prova4) / 4;

    if (media >= 5)
    {
      Console.WriteLine("Aluno aprovado.");
    }
    else if (media < 5 && media >= 3)
    {
      Console.WriteLine("Aluno em recuperacao.");
    }
    else
    {
      Console.WriteLine("Aluno reprovado.");
    }
  }
}