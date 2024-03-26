namespace Davizinhoamandinha;

public class paianimal
{
 private int fome;
 protected int sede;
 public int passear;


 public paianimal()
 {
    fome=0;
    sede=0;
    passear=0;
 }


 public void SetFome(int f)
{
    if (f <= 1 || f >=0)
        fome = f ;
        else if (f > 1)
        fome =1 ;
        else 
        fome = 0;
}

public int GetFome()
{
    return fome;


}
}