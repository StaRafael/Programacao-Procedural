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
      int somatorio = 0;

      do
      {
        int numeroRecebido = int.Parse(Console.ReadLine());

        if (numeroRecebido < 0)

        {
          break;
        }
        else if (numeroRecebido % 2 == 1)
        {
          somatorio = somatorio += numeroRecebido;
        }

      }
      while (true);

      Console.WriteLine("O somatorio de impares eh: " + somatorio);
    }
  }
}
