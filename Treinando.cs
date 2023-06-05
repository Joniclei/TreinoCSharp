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
         public Treinando(int nc, string name,double Valdeposito):this(nc,name)
        {
            this.Valdeposito = Valdeposito;
        }


        public override string ToString()
        {
            return $"\nConta: {NC}, Titular: {Name}, Saldo: {Valdeposito.ToString("C")}\n";
        }
    }
}
