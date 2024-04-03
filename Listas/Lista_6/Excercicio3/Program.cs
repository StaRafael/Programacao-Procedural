using System;

class Program
{
  static void Main(string[] args)

  {
    const int matrizTamanho = 3;
    int[,] matriz = new int[matrizTamanho, matrizTamanho];
    int somatorio = 0;

    for (int linha = 0; linha < matrizTamanho; linha++)
    {
      for (int coluna = 0; coluna < matrizTamanho; coluna++)
      {

        matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
      }
    }

    for (int linha = 0; linha < matrizTamanho; linha++)
    {
      for (int coluna = 0; coluna < matrizTamanho; coluna++)
      {
        if (linha == coluna)
        {
          somatorio += matriz[linha, coluna];
        }

      }
    }

    Console.WriteLine(somatorio);
  }
}