// "Se Φ(x) é uma propriedade provável de um objeto x do tipo T. Então Φ(y) deve ser verdade para objetos y do tipo S onde S é um subtipo de T."
// "Funções que usam apontadores ou referencia uma classe base devem poder usar objetos derivados sem saber."

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