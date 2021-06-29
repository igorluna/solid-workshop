
// "There should never be more than one reason for a class to change." In other words, every class should have only one responsibility.

public class Carne
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public int Peso { get; set; } 

    public ICarnePreparada Preparar(string tipoPreparo)
    {
        if(tipoPreparo == "Frita")
        {
            return new CarneAssada();
        } 
        else if (tipoPreparo == "NaPressao")
        {
            return new CarneCozida();
        } 
        else if (tipoPreparo == "NaBraza")
        {
            return new Churrasco();
        } 

        throw new System.Exception("Forma de preparo não cadastrada.");
    }
}
