// “Clients should not be forced to depend upon interfaces that they do not use.”

using System.Collections.Generic;

public interface IAcomodadorDeCompras
{
    void Esvazia();

    void AdicionaItemLeve(Item item);
}

public interface ICarrinhoDeCompraNovo
{
    void AcomodarCrianca(Crianca crianca);
}

public class CarrinhoNovo : ICarrinhoDeCompraNovo
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

public class CestaNova : ICarrinhoDeCompraNovo
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
