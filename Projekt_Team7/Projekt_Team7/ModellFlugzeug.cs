namespace Projekt_Team7;

public class ModellFlugzeug : ModellFahrzeug
{
    public ModellFlugzeug(Farbe farbe, Hersteller hersteller, string modell) : base(farbe, hersteller, modell)
    {
        
    }
    
    public string Verkaufen()
    {
        return "Das ModellFlugzeug " + base.Verkaufen();
    }

    public string Reparieren()
    {
        return "Das ModellFlugzeug " + base.Verkaufen();
    }

    public string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return "Das ModellFlugzeug " + base.Einfaerben(farbe);
    }

    public override bool Verleihen()
    {
        Console.WriteLine("Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " wird verliehen.");
        Verfuegbar = false;
        return Verfuegbar;
    }

    public override bool Zurueckgeben()
    {
        Console.WriteLine("Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " wurde zurueckgegeben.");
        Verfuegbar = true;
        return Verfuegbar;
    }

    public string ToString()
    {
        return "ModellFlugzeug: " + base.ToString();
    }
}