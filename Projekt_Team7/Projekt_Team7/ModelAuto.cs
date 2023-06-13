namespace Projekt_Team7;

public class ModelAuto : ModelFahrzeug
{

    public ModelAuto(Farbe farbe, Hersteller hersteller, string model) : base(farbe, hersteller, model)
    {
        
    }
    public string Verkaufen()
    {
        return "Das ModelAuto " + base.Verkaufen();
    }

    public string Reparieren()
    {
        return "Das ModelAuto " + base.Reparieren();
    }

    public string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return "Das ModelAuto " + base.Einfaerben(farbe);
    }

    public override bool Verleihen()
    {
        Console.WriteLine("Das ModelAuto " + Model + " vom Hersteller " + Hersteller + " mit der Farbe: "+Farbe+" wird verliehen.");
        Verfuegbar = false;
        return Verfuegbar;
    }

    public override bool Zurueckgeben()
    {
        Console.WriteLine("Das ModelAuto " + Model + " vom Hersteller " + Hersteller + " mit der Farbe: " + Farbe + " wurde zurueckgegeben.");
        Verfuegbar = true;
        return Verfuegbar;
    }

    public  string ToString()
    {
        return "ModelAuto: " + base.ToString();
    }
}