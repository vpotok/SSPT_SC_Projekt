namespace Projekt_Team7;

public class DatenBank
{
    private ModelFlugzeug[] listeFahrzeuge = new ModelFlugzeug[0];

    
    public string  Hinzufuegen(string art,string model, string hersteller, string farbe)
    {
        ModelFlugzeug newm;
        switch (art)
        {
            case "Auto":
                newm = new ModelFlugzeug(Farbe.Blau, Hersteller.Airbus, model);
                break;
            case "Flugzeug":
                
                break;
            default:
                break;
        }
        
        
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