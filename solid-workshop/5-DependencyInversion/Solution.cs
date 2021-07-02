// "Modulos de alto nivel não devem depender de modulos de baixo nivel. Ambos devem depender de abstrações."
// "Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações."

using System;
using System.Collections.Generic;

public class BibliotecaNova 
{
    IDateTimeProvider _dateTimeProvider;
    ILivrosDataBase _livroDataBase;

    public BibliotecaNova(
        IDateTimeProvider dateTimeProvider,
        ILivrosDataBase livroDataBase)
    {
        _dateTimeProvider = dateTimeProvider;
        _livroDataBase = livroDataBase;
    }

    public List<Livro> ObterLivros()
    {
        return _livroDataBase.ObtemLivros();
    }

    public void AdicionarLivro(Livro novoLivro)
    {
        novoLivro.DataCadastro = _dateTimeProvider.Now;
        _livroDataBase.Salvar(novoLivro);
    }
}

public interface IDateTimeProvider
{
    DateTime Now { get; }
}

public interface ILivrosDataBase
{
    List<Livro> ObtemLivros();
    void Salvar(Livro novoLivro);
}