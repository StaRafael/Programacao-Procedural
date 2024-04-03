using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_DE_NOME = 10;
    string[] nome = new string[QUANTIDADE_DE_NOME];

    for (int linha = 0; linha < QUANTIDADE_DE_NOME; linha++)
    {
      nome[linha] = Console.ReadLine();
    }

    for (int linha = QUANTIDADE_DE_NOME - 1; linha >= 0; linha--)
    {
      if (linha % 2 == 0)
      {
        Console.WriteLine(nome[linha]);
      }
    }
  }
}