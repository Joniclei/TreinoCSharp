namespace Treino
{
  public class Treinando
    {
        public int NC {get; private set;}

        public string Name{get;set;}
        public double Valdeposito {get;private set;}

        public Treinando(int nc, string name)
        {
            this.NC = nc;
            this.Name = name;
        }
         public Treinando(int nc, string name,double Valdepositoinicial):this(nc,name)
        {
            Deposito(Valdepositoinicial);
        }

        public  void  Deposito (double valdeposito2){
          this.Valdeposito += valdeposito2;
        }

        public void Saque(double valdeposito2)
        {
          this.Valdeposito -= (valdeposito2 + 5);
        }


        public override string ToString()
        {
            return $"\nConta: {NC}, Titular: {Name}, Saldo: {Valdeposito.ToString("C")}\n";
        }
    }
}
