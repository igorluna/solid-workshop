// "High-level modules should not depend on low-level modules, both should depend on abstractions. Abstractions should not depend on details, details should depend on abstractions."

using System;
using System.Collections.Generic;

public class Biblioteca 
{
    public List<Livro> ObterLivros()
    {
        // New é um code smell
        LivrosDataBase database = new LivrosDataBase();
        return database.ObtemLivros();
    }

    public void AdicionarLivro(Livro novoLivro)
    {
        LivrosDataBase database = new LivrosDataBase();
        
        // Uso de classes estáticas é code smell
        novoLivro.DataCadastro = DateTime.Now;
        database.Salvar(novoLivro);
    }
}