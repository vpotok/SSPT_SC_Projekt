namespace Projekt_Team7;

public class ModelFlugzeug : ModelFahrzeug
{
    public ModelFlugzeug(Farbe farbe, Hersteller hersteller, string model) : base(farbe, hersteller, model)
    {
        
    }
    
    public string Verkaufen()
    {
        return "Das ModelFlugzeug " + base.Verkaufen();
    }

    public string Reparieren()
    {
        return "Das ModelFlugzeug " + base.Verkaufen();
    }

    public string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return "Das ModelFlugzeug " + base.Einfaerben(farbe);
    }

    public override bool Verleihen()
    {
        Console.WriteLine("Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " wird verliehen.");
        Verfuegbar = false;
        return Verfuegbar;
    }

    public override bool Zurueckgeben()
    {
        Console.WriteLine("Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " wurde zurueckgegeben.");
        Verfuegbar = true;
        return Verfuegbar;
    }

    public string ToString()
    {
        return "ModelFlugzeug: " + base.ToString();
    }
}