using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_DE_PESSOAS = 10;
    string[] nome = new string[QUANTIDADE_DE_PESSOAS];
    bool resultado = false;

    for (int linha = 0; linha < QUANTIDADE_DE_PESSOAS; linha++)
    {
      nome[linha] = Console.ReadLine();
    }

    string pesquisa_Nome = Console.ReadLine();

    for (int linha = 0; linha < QUANTIDADE_DE_PESSOAS; linha++)
    {
      if (pesquisa_Nome == nome[linha])
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