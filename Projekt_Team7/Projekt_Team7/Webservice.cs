namespace Projekt_Team7;

public class Webservice
{
    public DatenBank Datenbank { get; set; } = new DatenBank();

    public Webservice ()
    {
    }

    public string Get(string modellName, string methode)
    {
        string ausg = "";
        switch (methode)
        {
            case "Verleihen":
                ausg = Datenbank.Verleihen(modellName);
                return ausg;

            case "Reparieren":
                ausg = Datenbank.Reparieren(modellName);
                return ausg;

            case "Zurueckgeben":
                ausg = Datenbank.Zurueckgeben(modellName);
                return ausg;
            case "AusgabeListe":
                ausg = Datenbank.Zurueckgeben(modellName);
                return ausg;

            default:
                return $"Ungültige Methode: {methode}";
        }
    }

    // Einfaerben
    public string Put(int farbe, string modell)
    {
        string ausg = Datenbank.Einfaerben(modell,farbe);
        return ausg;
    }

    public string Put(string modell)
    {
        // Logik für den POST-Request zum Hinzufügen eines Fahrzeugs zur Datenbank
        return $"POST Request -  Model: {modell}";
    }

    public string Delete(string modellName) //verkauf 
    {
        return $"DELETE Request f�r {modellName}";

    }

}