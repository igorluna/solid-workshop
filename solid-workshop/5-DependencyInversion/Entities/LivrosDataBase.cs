using System;
using System.Collections.Generic;

public class LivrosDataBase
{
    internal List<Livro> ObtemLivros()
    {
        return new List<Livro>();
    }

    internal void Salvar(Livro novoLivro)
    {
        // Salvou o livro!
    }
}

public class Livro
{
    public DateTime DataCadastro { get; internal set; }
}