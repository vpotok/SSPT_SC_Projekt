namespace Projekt_Team7;

public class DatenBank
{
    private List<ModellFlugzeug> listeFahrzeuge = new List<ModellFlugzeug>();

    
    public string  Hinzufuegen(string art,string Modell, int hersteller, int farbe)
    {
        ModellFlugzeug newm = null;
        switch (art)
        {
            case "Auto":
                newm = new ModellFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), Modell);
                break;
            case "Flugzeug":
                newm = new ModellFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), Modell);
                break;
            default:
                break;
        }

        listeFahrzeuge.Add(newm);
        return "false";
    }

    public bool Verkaufen()
    {
        return false;
    }

    public string Suchen()
    {
        return null;
    }

    public bool Vorhanden()
    {
        return true;
    }
    
}