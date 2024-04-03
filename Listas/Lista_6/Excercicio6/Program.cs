using System;
class Program
{
  static void Main(string[] args)
  {
    const int tamanhoMatriz = 4;
    int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];

    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
      for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
      {
        matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
      }
    }

    int escolha = Convert.ToInt32(Console.ReadLine());

    if (escolha == 1)
    {
      for (int linha = 0; linha < tamanhoMatriz; linha++)
      {
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
          Console.WriteLine(matriz[linha, coluna]);
        }
      }
    }
    else if (escolha == 2)
    {
      int somatorio = 0;
      for (int linha = 0; linha < tamanhoMatriz; linha++)
      {
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
          somatorio += matriz[linha, coluna];
        }
      }

      Console.WriteLine(somatorio);
    }

    else if (escolha == 3)
    {
      int somatorio = 0;
      for (int linha = 0; linha < tamanhoMatriz; linha++)
      {
        somatorio += matriz[2, linha];
      }
      Console.WriteLine(somatorio);
    }

    else if (escolha == 4)
    {
      int somatorio = 0;
      for (int linha = 0; linha < tamanhoMatriz; linha++)
      {
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
          if (linha == coluna)
          {
            somatorio += matriz[linha, coluna];
          }
        }
      }
      Console.WriteLine(somatorio);
    }

    else if (escolha == 5)
    {
      int somatorio = 0;
      for (int linha = 0; linha < tamanhoMatriz; linha++)
      {
        if (matriz[linha, 1] % 2 == 0)
        {
          somatorio += matriz[linha, 1];
        }
      }
      Console.WriteLine(somatorio);
    }
  }
}