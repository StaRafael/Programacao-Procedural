using System;
using System.Reflection.Metadata;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Converter os centavos em reais: ");
    int valor = int.Parse(Console.ReadLine());

    int real = valor / 100;
    int centavo = valor % 100;


    Console.WriteLine("O total em dinheiro eh: " + real + " real(is) " + centavo + " centavo(S) ");

  }
}