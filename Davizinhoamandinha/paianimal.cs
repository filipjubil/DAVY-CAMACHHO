namespace Davizinhoamandinha;

public class paianimal
{
 private double fome;
 protected double sede;
 public double passear;


 public paianimal()
 {
    fome=0.5;
    sede=0;
    passear=0;
 }


 public void SetFome(double f)
{
    if (f <= 1 || f >=0)
        fome = f ;
        else if (f > 1)
        fome =1 ;
        else 
        fome = 0;
}

public double GetFome()
{
    return fome;


}
}