/*
In a computer program, if type B is a subtype of type A then objects of type A may be replaced 
with objects of type B without altering any of the desirable properties of type A.
In essence it means that every subclass should be substitutable for their base class.
*/
public class Principal
{
    public void Teste(Pato pato)  
    {
      pato.Nadar();
    }
}


public class Pato
{
    public virtual void Nadar()
    {
      // Nadou!
    }
}

public class PatoDeBrinquedo : Pato
{
    private bool temBateria;
    public override void Nadar()
    {
      //if (temBateria)
      //      Nadou!
    }
}