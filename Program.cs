using System;


namespace Treino
{
  class Program
  {
    static void Main(string[] args)
    {
      bool continuar = true;

      do {

      Console.Write("Entre o numero da conta :");
      int nconta = Convert.ToInt32(Console.ReadLine());

      Console.Write("Entre o titular da conta :");
      string name = Console.ReadLine();

      Console.Write("Havera deposito inicial(S/N) :");
      string vaidepositar = (Console.ReadLine());
      int valdeposito = 0;
      if (vaidepositar.ToUpper() == "S")
      {
        Console.Write("Entre o valor de deposito inicial :");
        valdeposito = Convert.ToInt32(Console.ReadLine());
      }

      Treinando conta = new Treinando(nconta, name, valdeposito);


      Console.Write($"Dados da conta : {conta}");

      Console.Write("continuar S/N");
      string x = Console.ReadLine();
      continuar = x.ToUpper() == "S" ?  true : false;


      } while(continuar);


    }
  }
}

