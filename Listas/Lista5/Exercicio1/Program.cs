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


      const int contagem_Max = 100;

      const int contagem_Min = 0;


      int regressivo_Min = 0;

      int regressivo_Max = 204;

      while (regressivo_Min <= contagem_Max && regressivo_Max >= contagem_Min)
      {
        regressivo_Max -= 4;

        Console.WriteLine($"{regressivo_Min} - {regressivo_Max}");

        regressivo_Min += 2;

      }
    }
  }
}