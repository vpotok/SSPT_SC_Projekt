namespace Projekt_Team7;

public class Webservice
{
    public DatenBank Datenbank { get; set; } = new DatenBank();

    public Webservice ()
    {
        //string art,string Modell, int hersteller, int farbe
        Put("Auto", "A4", 1,3);
        Put("Auto", "E46", 0,4);
        Put("Auto", "A7", 1,5);
        Put("Flugzeug", "747", 2,2);
        Put("Flugzeug", "737", 2,0);
        Put("Flugzeug", "A350", 3,5);
        
    }

    public string Get(string modellName, string methode)
    {
        // Verleihen, Reparieren, Zurueckgeben (wenn ausgeliehen) eines ModelFahrzeuges
        // AusgabeListe aller verfuegbbaren Modelfahzeuge
        string ausg = "";
        switch (methode)
        {
            case "Verleihen":
                ausg = Datenbank.Verleihen(modellName);
                break;
            case "Reparieren":
                ausg = Datenbank.Reparieren(modellName);
                break;
            case "Zurueckgeben":
                ausg = Datenbank.Zurueckgeben(modellName);
                break;
            case "AusgabeListe":
                ausg = Datenbank.Zurueckgeben(modellName);
                break;
            default:
                ausg = $"Ungueltige Methode: {methode}";
                break;
        }

        return ausg;
    }

    public string GET(string ModellArt)
    {
        // Ausgabe der zum Verkauf/verleih stehenden Fahrzeuge
        string ausg = Datenbank.Verfuegbar(ModellArt);
        return ausg;
    }

    // Einfaerben
    public string Put(string modell, int farbe)
    {
        //Einfaerben eines Modellfahrzeuges
        string ausg = Datenbank.Einfaerben(modell,farbe);
        return ausg;
    }

    public string Put(string art,string Modell, int hersteller, int farbe)
    {
        // Logik für den PUT-Request zum Hinzufuegen eines Fahrzeugs zur Datenbank
        Datenbank.Hinzufuegen(art, Modell, hersteller, farbe);
        return null;
    }

    public string Delete(string modellName) 
    {
        // Verkauf eines ModellFahrzeuges
        string ausg = "";
        ausg = Datenbank.Verkaufen(modellName);
        
        return ausg;

    }


}