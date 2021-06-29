// “Clients should not be forced to depend upon interfaces that they do not use.”
using System.Collections.Generic;

public interface ICarrinhoDeCompra
{
    void Esvazia();

    void AdicionaItemLeve(Item item);

    void AcomodarCrianca(Crianca crianca);
}

public class Carrinho : ICarrinhoDeCompra
{
    private Crianca _crianca;

    private List<Item> _feira;

    public void AcomodarCrianca(Crianca crianca)
    {
        _crianca = crianca;
    }

    public void AdicionaItemLeve(Item item)
    {
        _feira.Add(item);
    }

    public void Esvazia()
    {
       _feira.Clear();
    }
}

public class Cesta : ICarrinhoDeCompra
{
    private List<Item> _feira;

    public void AcomodarCrianca(Crianca crianca)
    {
        throw new GuriNaoCabeAquiException();
    }

    public void AdicionaItemLeve(Item item)
    {
        _feira.Add(item);
    }

    public void Esvazia()
    {
       _feira.Clear();
    }
}