
// "There should never be more than one reason for a class to change." In other words, every class should have only one responsibility.

public class Mensagem
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public int Remetente { get; set; } 

    public string Converte(string formato)
    {
        if(formato == "json")
        {
            // Lógica que monta o json
            return @"{'json':'json'}";
        } 
        else if (formato == "xml")
        {
            // Lógica que monta o XML
            return "<xml> </xml>";
        } 
        else if (formato == "base64")
        {
            // Lógica que monta base64
            return "31923891283912839";
        } 

        throw new System.Exception("Esse formato não existe.");
    }
}
