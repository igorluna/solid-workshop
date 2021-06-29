public interface ICalculador
{
    double ObtemDistancia(Geolocalizacao origem, Geolocalizacao destino);
}

public class CalculadorViajemNova : ICalculador
{
    private EnumPriorisarTipoEstrada _estrada;
    public void ConfigureTipoDeViagem(EnumPriorisarTipoEstrada estrada)
    {
        _estrada = estrada;
    }

    public double ObtemDistancia(Geolocalizacao origem, Geolocalizacao destino)
    {
        if(_estrada == EnumPriorisarTipoEstrada.ApenasBR)
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
public class CalculadorDistanciaNova : ICalculador
{
    public double ObtemDistancia(Geolocalizacao origem, Geolocalizacao destino)
    {
        return 0;
    }
}