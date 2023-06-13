namespace Projekt_Team7;

public class ModellAuto : ModellFahrzeug
{

    public ModellAuto(Farbe farbe, Hersteller hersteller, string modell) : base(farbe, hersteller, modell)
    {
        
    }
    public string Verkaufen()
    {
        return "Das ModellAuto " + base.Verkaufen();
    }

    public string Reparieren()
    {
        return "Das ModellAuto " + base.Reparieren();
    }

    public string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return "Das ModellAuto " + base.Einfaerben(farbe);
    }

    public override bool Verleihen()
    {
        Console.WriteLine("Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe: "+Farbe+" wird verliehen.");
        Verfuegbar = false;
        return Verfuegbar;
    }

    public override bool Zurueckgeben()
    {
        Console.WriteLine("Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe: " + Farbe + " wurde zurueckgegeben.");
        Verfuegbar = true;
        return Verfuegbar;
    }

    public  string ToString()
    {
        return "ModellAuto: " + base.ToString();
    }
}