namespace Davizinhoamandinha;

public class paianimal
{
 private double fome;
 protected double sede;
 public double carinho;


 public paianimal()
 {
    Comida=0.5;
    Agua=0;
    Carinho=0;
 }


 public void SetComida(double f)
{
    if (f <= 1 || f >=0)
        fome = f ;
        else if (f > 1)
        fome =1 ;
        else 
        fome = 0;
}

public double GetComida()
{
    return Comida;


}
}