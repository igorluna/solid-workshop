// “Clientes não devem depender de interfaces que não usam.”


public interface ICarrinhoDeCompra
{
    void Esvazia();

    void AdicionaItem(string item);

    void AcomodarCrianca(string crianca);
}

public class Carrinho : ICarrinhoDeCompra
{
    public void AcomodarCrianca(string crianca) { }

    public void AdicionaItem(string item) { }

    public void Esvazia() { }
}

public class Cesta : ICarrinhoDeCompra
{
    public void AcomodarCrianca(string crianca)
    {
        throw new System.Exception("Não cabe um guri aqui!");
    }

    public void AdicionaItem(string item) { }

    public void Esvazia() { }
}