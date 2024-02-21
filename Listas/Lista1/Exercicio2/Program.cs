using System;
using System.Reflection.Metadata;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a base do Triangulo: ");
    double baseTriangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura do Triangulo: ");
    double alturaTriangulo = double.Parse(Console.ReadLine());

    bool triangulo = baseTriangulo >= 20;

    double area = (baseTriangulo * alturaTriangulo) / 2;

    Console.WriteLine("A área do Triângulo é:" + area + triangulo);

  }
}