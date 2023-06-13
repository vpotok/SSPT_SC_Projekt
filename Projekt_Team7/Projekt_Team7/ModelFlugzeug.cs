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

    public bool Verleihen(int sec)
    {
        Console.WriteLine("Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " mit der Farbe: "+Farbe+" wird fuer "+sec+" Milisekunden verliehen.");
        Verfuegbar = false;
        return Verfuegbar;
    }
    
    public string ToString()
    {
        return "ModelFlugzeug: " + base.ToString();
    }
}