using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  public class Program
  {
    public static void Main(string[] args)
    {
      for (int esquerda = 10; esquerda >= 0; esquerda--)
      {
        for (int direita = 0; direita <= 10; direita++)
        {
          Console.WriteLine($"{esquerda}  x  {direita}  =  {esquerda * direita}");
        }

        Console.WriteLine();
      }

    }
  }
}