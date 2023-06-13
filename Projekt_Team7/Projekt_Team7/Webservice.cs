namespace Projekt_Team7;

public class Webservice
{
    private DB Datenbank;
    public Wevservice (DB datenBank)
    {
        Datenbank = datenBank;
    }

    public string Get(string modelName, string methode)
    {
        return $"GET Request für {modelName} - Methode: {methode}";
    }

    public string Post (Farbe farbe, string model, Hersteller hersteller)
    {
        return $"GET Request für {modelName} - Methode: {methode}";

    }

    public string Delete(string modelName)
    {
        return $"DELETE Request für {modelName}";

    }

}