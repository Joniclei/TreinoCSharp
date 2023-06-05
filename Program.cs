using System;

namespace Treino
{
  class Program
  {
    static void Main(string[] args)
    {

      double valdeposito;
      Treinando conta;
      Console.Write("Entre o número da conta: ");
      int nconta = Convert.ToInt32(Console.ReadLine());

      Console.Write("Entre o titular da conta: ");
      string name = Console.ReadLine();

      Console.Write("Haverá depósito inicial (S/N): ");
      char vaidepositar = Convert.ToChar(Console.ReadLine());
      if (vaidepositar == 'S' || vaidepositar == 's')
      {
        Console.Write("Entre o valor de depósito inicial: ");
        valdeposito = Convert.ToDouble(Console.ReadLine());
        conta = new Treinando(nconta, name,valdeposito);
      }
      else{
        conta = new Treinando (nconta,name);
      }

      Console.WriteLine();
      Console.WriteLine("Dados Conta:");
      Console.WriteLine(conta);

      Console.WriteLine("Entre com um valor para deposito");
      double valdeposito2 = Convert.ToDouble(Console.ReadLine());
      conta.Deposito(valdeposito2);

      Console.WriteLine();
      Console.WriteLine("Dados Conta atualizado:");
      Console.WriteLine(conta);

      Console.WriteLine("Entre com um valor para deposito");
      valdeposito2 = Convert.ToDouble(Console.ReadLine());
      conta.Saque(valdeposito2);

      Console.WriteLine();
      Console.WriteLine("Dados Conta atualizado:");
      Console.WriteLine(conta);

    }
  }
}



