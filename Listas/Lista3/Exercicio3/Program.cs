using System;

class Program
{
  static void Main(string[] args)
  {
    const string usuarioCorreto = "admin";
    const string senhaCorreto = "123senha";
    int acesso = 1;
    const int numerodeacesso = 3;

    do
    {
      Console.WriteLine("\nNome de usuario:");
      string nomeusuario = Console.ReadLine();
      Console.WriteLine("digite a sua senha:");
      string senha = Console.ReadLine();

      if (nomeusuario == usuarioCorreto && senha == senhaCorreto)
      {
        Console.WriteLine("Login realizado com sucesso");
        break;
      }
      acesso++;
    }
    while (acesso <= numerodeacesso);

    if (acesso > numerodeacesso)
    {
      Console.WriteLine("sua conta foi bloqueada");
    }
  }
}