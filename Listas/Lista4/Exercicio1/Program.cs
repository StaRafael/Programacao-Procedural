using System;

class Program
{
  static void Main(string[] args)
  {
    for (int esquerda = 1; esquerda <= 10; esquerda++)
    {
      for (int direita = 1; direita <= 10; direita++)
      {
        Console.WriteLine(esquerda + " x " + direita + " = " + esquerda * direita);
      }
      Console.WriteLine();
    }
    Console.Read();
  }
}