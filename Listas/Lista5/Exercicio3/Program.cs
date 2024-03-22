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
      int altura = int.Parse(Console.ReadLine());

      int _baselinha = int.Parse(Console.ReadLine());

      System.Console.WriteLine();

      for (int coluna = 1; coluna <= altura; coluna++)
      {
        for (int linha = 1; linha <= _baselinha; linha++)
        {
          System.Console.Write("*");
        }
        System.Console.WriteLine();

      }
    }
  }
}