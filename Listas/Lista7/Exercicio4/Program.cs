using System;

public class Program
{
  public static void Main(string[] args)
  {
    int[] numeroDeVaga = new int[12];

    vagao(numeroDeVaga);

    peso(numeroDeVaga);
  }
  public static void vagao(int[] trem)
  {
    for (int linha = 0; linha < 12; linha++)
    {
      trem[linha] = Convert.ToInt32(Console.ReadLine());
    }
  }
  public static void peso(int[] trem)
  {
    for (int linha = 0; linha < 12; linha++)
    {
      if (trem[linha] > 50)
      {
        Console.WriteLine($"{linha + 1}° vagao ultrapassou o limite de peso");
      }
    }
  }
}