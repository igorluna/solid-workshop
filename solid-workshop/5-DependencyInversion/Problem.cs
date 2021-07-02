// "Modulos de alto nivel não devem depender de modulos de baixo nivel. Ambos devem depender de abstrações."
// "Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações."


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