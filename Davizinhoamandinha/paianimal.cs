namespace Davizinhoamandinha;

public class paianimal
{
 private double Comida;
 protected double Agua;
 public double Carinho;

 public double Arquivo;


 public paianimal()
 {
    Comida=0.1;
    Agua=0.1;
    Carinho=0.1;
 }


 public void SetComida(double f)
{
    if (f <= 1 || f >=0)
        Comida = f ;
        else if (f > 1)
        Comida =1 ;
        else 
        Comida = 0;
}

public double GetComida()
{
    return Comida;


}
public void SetAgua(double f)
{
    if (f <= 1 || f >=0)
        Agua = f ;
        else if (f > 1)
        Agua =1 ;
        else 
        Agua = 0;
}

public double GetAgua()
{
    return Agua;


}
public void SetCarinho(double f)
{
    if (f <= 1 || f >=0)
        Carinho = f ;
        else if (f > 1)
        Carinho =1 ;
        else 
        Carinho = 0;
}

public double GetCarinho()
{
    return Carinho;


}
public double GetArquivo()
{
    return Arquivo;


}
}