// Calcula distancia considerando ruas/estradas
public class CalculadorViajem
{
    public double ObtemDistancia(Geolocalizacao origem, Geolocalizacao destino, EnumPriorisarTipoEstrada estrada)
    {
        if(estrada == EnumPriorisarTipoEstrada.ApenasBR)
        {          
          // faz algo
        }
        else
        { 
          // faz outra coisa
        }

        return 0;
    }
}

// Calcula distancia apenas considerando os pontos de origem e destino
public class CalculadorDistancia
{
    public double ObtemDistancia(Geolocalizacao origem, Geolocalizacao destino)
    {
        return 0;
    }
}

public class Geolocalizacao {}

public enum EnumPriorisarTipoEstrada 
{
    ApenasBR,
    PodeUsar
}