using System;

class Program
{
  static void Main(string[] args)
  {
    Tabuleiro.InicializaTabuleiro();

    const int Borda = 8;

    for (int linha = 0; linha < Borda; linha++)
    {
      for (int coluna = 0; coluna < Borda; coluna++)
      {
        if (linha == 0 || linha == Borda - 1 || coluna == 0 || coluna == Borda - 1)
        {
          Tabuleiro.Adicionar(linha, coluna, "S");
        }

      }

    }

    Tabuleiro.ImprimeTabuleiro();

  }
}
