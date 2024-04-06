using System;

class Program
{
  static void Main(String[] args)
  {
    int idade = Convert.ToInt32(Console.ReadLine());
    classificaoNadador(idade);
  }
  static void classificaoNadador(int idade)
  {
    if (idade < 12)
    {
      Console.WriteLine($"Infantil");
    }
    else if (idade >= 12 && idade <= 14)
    {
      Console.WriteLine($"Juvenil A");
    }
    else if (idade >= 15 && idade <= 17)
    {
      Console.WriteLine($"Juvenil B");
    }
    else
    {
      Console.WriteLine($"Adulto");
    }
  }
}