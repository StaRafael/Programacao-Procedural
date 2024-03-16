using System;

class Program
{
  static void Main(string[] args)
  {
    const int LIMITE = 9;

    Console.WriteLine("Digete um número");
    int altura = int.Parse(Console.ReadLine());

    if (altura <= LIMITE)
    {
      System.Console.WriteLine();
      for (int coluna = 1; coluna <= altura; coluna++)
      {
        for (int linha = 1; linha <= coluna; linha++)
        {
          Console.Write(linha);
        }
        Console.WriteLine();
      }
    }
    else
    {
      Console.WriteLine("Altura invalida, insira uma altura entre 1 e 9");
    }
  }
}