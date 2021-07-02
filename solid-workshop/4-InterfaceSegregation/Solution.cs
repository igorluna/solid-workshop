// “Clients should not be forced to depend upon interfaces that they do not use.”

public interface IAcomodadorDeCompras
{
    void Esvazia();

    void AdicionaItemLeve(string item);
}

public interface IAcomadaCrianca
{
    void AcomodarCrianca(string crianca);
}

public class CarrinhoNovo : IAcomodadorDeCompras, IAcomadaCrianca
{
    public void AcomodarCrianca(string crianca){}

    public void AdicionaItemLeve(string item){}

    public void Esvazia(){}
}

public class CestaNova : IAcomodadorDeCompras
{
    public void AdicionaItemLeve(string item){}

    public void Esvazia() {}
}
