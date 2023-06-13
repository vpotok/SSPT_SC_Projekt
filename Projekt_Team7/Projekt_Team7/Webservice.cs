namespace Projekt_Team7;

public class Webservice
{
    public DatenBank Datenbank { get; set; } = new DatenBank();

    public Webservice ()
    {
    }

    public string Get(string modelName, string methode)
    {
        string ausg = "";
        switch (methode)
        {
            case "Verleihen":
                ausg = Datenbank.Verleihen(modelName);
                return ausg;

            case "Reparieren":
                ausg = Datenbank.Reparieren(modelName);
                return ausg;

            case "Zurueckgeben":
                ausg = Datenbank.Zurueckgeben(modelName);
                return ausg;

            default:
                return $"Ungültige Methode: {methode}";
        }
    }

    // Einfaerben
    public string Put(int farbe, string model)
    {
        string ausg = Datenbank.Einfaerben(model,farbe);
        return ausg;
    }

    public string Put( string model)
    {
        // Logik für den POST-Request zum Hinzufügen eines Fahrzeugs zur Datenbank
        string ausg = 
        return $"POST Request - Farbe: {farbe}, Model: {model}";
    }

    public string Delete(string modelName) //verkauf 
    {
        return $"DELETE Request f�r {modelName}";

    }

}