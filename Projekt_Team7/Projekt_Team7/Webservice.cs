namespace Projekt_Team7;

public class Webservice
{
    public DatenBank Datenbank { get; set; } = new DatenBank();

    public Webservice ()
    {
    }

    public string Get(string ModellName, string methode)
    {
        return $"GET Request f�r {ModellName} - Methode: {methode}";
    }

    public string Post (Farbe farbe, string Modell, Hersteller hersteller)
    {
        return $"GET Request f�r {ModellName} - Methode: {methode}";

    }

    public string Delete(string ModellName)
    {
        return $"DELETE Request f�r {ModellName}";

    }

}