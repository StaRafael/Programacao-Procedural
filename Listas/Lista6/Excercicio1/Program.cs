using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANT_NOMES = 3;
    string[] nomePessoas = new string[QUANT_NOMES];

    for (int i = 0; i < QUANT_NOMES; i++)
    {
      nomePessoas[i] = Console.ReadLine();
    }

    string buscarNome = Console.ReadLine();

    bool nomeEncontrado = false;

    for (int i = 0; i < QUANT_NOMES; i++)
    {
      if (nomePessoas[i] == buscarNome)
      {
        nomeEncontrado = true;
        break;
      }
    }

    if (nomeEncontrado)
    {
      Console.WriteLine("ACHEI");
    }
    else
    {
      Console.WriteLine("NAO ACHEI");
    }
  }
}