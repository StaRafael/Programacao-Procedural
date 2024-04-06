using System;

class Program
{
  static void Main()
  {
    int[,] rpgFire = matriz();
    bool verificar = exsitem(rpgFire);
    if (verificar)
    {
      Console.WriteLine($"Fique atento! existem balistas no tabuleiro");
    }
  }
  static int[,] matriz()
  {
    const int TAMANHO_MATRIZ = 4;
    int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

    for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
    {
      for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
      {
        matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
      }
    }
    return matriz;
  }
  static bool exsitem(int[,] matriz)
  {
    const int TAMANHO_MATRIZ = 4;
    for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
    {
      for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
      {
        if (matriz[linha, coluna] == 0)
        {
          return true;

        }
      }
    }
    return false;
  }
}