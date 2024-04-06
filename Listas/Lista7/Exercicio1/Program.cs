using System;
public class Program
{
  public static void Main(String[] args)
  {
    int valor = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(NumeroPar(valor));
  }

  static bool NumeroPar(int numero)
  {
    return numero % 2 == 0;
  }

}