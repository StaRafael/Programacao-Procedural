using System;

class Program
{
  static void Main(string[] args)
  {
    const int tamanhoMatriz = 3;
    int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];
    int diagonal_secundaria = tamanhoMatriz - 1;

    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
      for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
      {
        if (coluna == diagonal_secundaria)
        {
          matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine()) * 2;
          diagonal_secundaria--;
        }
        else
        {
          matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
        }
      }
    }

    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
      for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
      {
        Console.Write(matriz[linha, coluna] + "|");
      }
      Console.WriteLine();
    }
  }
}