namespace Treino
{
  public class Treinando
  {

    private int _nc {get;set;}
    public string Name;

    private int Valdeposito;

    public Treinando (int nc, string name)
    {
      this._nc = nc;
      this.Name = name;


    }
    public Treinando (int nc, string name,int valdeposito)
    {
      this._nc = nc;
      this.Name = name;
      this.Valdeposito += valdeposito;

    }



    public override string ToString()
    {

      return $" \n Conta:{_nc} , Titular: {Name} , Saldo : {Valdeposito}   \n " ;
    }





  }
}
