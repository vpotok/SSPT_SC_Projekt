namespace Projekt_Team7;

public class Webservice
{
    public DatenBank Datenbank { get; set; } = new DatenBank();

    public Webservice ()
    {
    }

    public string Get(string modelName, string methode)
    {
        switch (methode)
        {
            case "verleihen":
                // Logik für Verleihen
                return $"Verleihen von {modelName}";

            case "reparieren":
                // Logik für Reparieren
                return $"Reparieren von {modelName}";

            case "zurueckgeben":
                // Logik für Zurückgeben
                return $"Zurückgeben von {modelName}";

            default:
                return $"Ungültige Methode: {methode}";
        }
    }

    public string Post(Farbe farbe, string model, Hersteller hersteller)
    {
        // Logik für den POST-Request zum Hinzufügen eines Fahrzeugs zur Datenbank
        Datenbank.Hinzufuegen("Flugzeug", model, (int)hersteller, (int)farbe);
        return $"POST Request - Farbe: {farbe}, Model: {model}, Hersteller: {hersteller}";
    }

    public string Post(Farbe farbe, string model)
    {
        // Logik für den POST-Request zum Hinzufügen eines Fahrzeugs zur Datenbank
        Datenbank.Hinzufuegen("Auto", model, 0, (int)farbe);
        return $"POST Request - Farbe: {farbe}, Model: {model}";
    }

    public string Delete(string modelName) //verkauf 
    {
        return $"DELETE Request f�r {modelName}";

    }

}