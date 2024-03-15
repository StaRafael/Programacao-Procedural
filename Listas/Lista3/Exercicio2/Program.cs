using System;
public class Program
{
  static void Main(string[] args)
  {
    const double VALOR_GRATIS = 100.00;
    double valorItem = 0;

    double total = 0;

    int contador = 1;

    Console.WriteLine("Quantidade de itens comprado na loja?");
    int quantidaitem = int.Parse(Console.ReadLine());

    while (contador <= quantidaitem)
    {
      Console.WriteLine("O preco do " + contador + "º item?");
      total = double.Parse(Console.ReadLine());
      valorItem = valorItem + total;
      contador++;
    }

    if (valorItem >= VALOR_GRATIS)
    {
      Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor de R$ "
      + Math.Round(valorItem, 2));
    }
    else
    {
      Console.WriteLine("Voce nao tem compra frete gratis");
    }
  }
}