using System;


class Program
{
  static void Main(string[] args)
  {
    const int HABITANTES = 20;
    int quantidadeDEfilhos = 0;
    double salarios = 0;
    double maiorSalario = 0;



    for (int contador = 1; contador <= HABITANTES; contador++)
    {
      Console.WriteLine("Qual é o salario do " + contador + "º habitantes");
      double valorDosalario = double.Parse(Console.ReadLine());
      Console.WriteLine("Quantidade de filhos do " + contador + "º habitantes");
      int quantidadeDEfilhos = int.Parse(Console.ReadLine());

      somarSalarios = somarSalarios + valorDosalario;


      if (valorDOsalario > salarios)
      {
        maiorSalario = valorDosalario
      }

    }

    quantidadeDEfilhos = quantidadeDEfilhos / HABITANTES;
    salarios = salarios / HABITANTES;

    System.Console.WriteLine(" a media salarial eh: R$" + Math.Round(salarios, 2));
    System.Console.WriteLine("a media de filhos por habitante eh:" + quantidadeDEfilhos);
    System.Console.WriteLine("o maior salario eh: R$" + maiorSalario);

  }
}