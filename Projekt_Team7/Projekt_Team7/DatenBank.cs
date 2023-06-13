namespace Projekt_Team7;

public class DatenBank
{
    private List<ModelFlugzeug> listeFahrzeuge = new List<ModelFlugzeug>();

    
    public string  Hinzufuegen(string art,string model, int hersteller, int farbe)
    {
        ModelFlugzeug newm = null;
        switch (art)
        {
            case "Auto":
                newm = new ModelFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), model);
                break;
            case "Flugzeug":
                newm = new ModelFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), model);
                break;
            default:
                break;
        }

        listeFahrzeuge.Add(newm);
        return "false";
    }

    public bool Verkaufen() // da wird was aus der liste gelöscht mit pop?
    {
        return false;
    }

    public string Suchen() // 
    {
        return null;
    }

    public bool Vorhanden()
    {
        return true;
    }
    
}