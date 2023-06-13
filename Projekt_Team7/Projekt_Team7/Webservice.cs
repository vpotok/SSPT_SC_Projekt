namespace Projekt_Team7;

public class Webservice
{
    public DatenBank Datenbank { get; set; } = new DatenBank();

    public Webservice ()
    {
    }

    public string Get(string modelName, string methode)
    {
        return $"GET Request f�r {modelName} - Methode: {methode}";
    }

    public string Post (Farbe farbe, string model, Hersteller hersteller)
    {
        return $"GET Request f�r {model} - Methode: {methode}";

    }

    public string Delete(string modelName)
    {
        return $"DELETE Request f�r {modelName}";

    }

}