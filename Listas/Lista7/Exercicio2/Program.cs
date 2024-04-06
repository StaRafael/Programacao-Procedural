using System;

public class Program
{
  static void Main(String[] args)
  {
    int id1 = Convert.ToInt32(Console.ReadLine());
    int id2 = Convert.ToInt32(Console.ReadLine());
    int id3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(maior(id1, id2, id3));
  }

  static int maior(int numero1, int numero2, int numero3)
  {

    int valor = 0;

    if (numero1 > numero2 && numero1 > numero3)
    {
      valor = numero1;
    }
    else if (numero2 > numero1 && numero2 > numero3)
    {
      valor = numero2;
    }
    else
    {
      valor = numero3;
    }
    return valor;
  }
}