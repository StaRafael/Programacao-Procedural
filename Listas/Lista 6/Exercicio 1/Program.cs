using System;

class Program
{
  static void Main(string[] args)
  {
    const int QAUNTIDADE_PESSOAS = 10;
    string[] nome = new string[QAUNTIDADE_PESSOAS];
    bool resultado = false;

    for (int linha = 0; linha < QAUNTIDADE_PESSOAS; linha++)
    {
      nome[linha] = Console.ReadLine();
    }

    string pesquisa = Console.ReadLine();

    for (int linha = 0; linha < QAUNTIDADE_PESSOAS; linha++)
    {
      if (pesquisa == nome[linha])
      {
        resultado = true;
      }
    }

    if (resultado == true)
    {
      Console.WriteLine("ACHEI");
    }
    else
    {
      Console.WriteLine("NAO ACHEI");
    }

  }
}