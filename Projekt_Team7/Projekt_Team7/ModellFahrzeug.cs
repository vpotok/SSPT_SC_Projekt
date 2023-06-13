namespace Projekt_Team7;

public abstract class ModellFahrzeug : IModellFahrzeug
{
    public bool Verfuegbar { get; set; } = true;
    public Farbe Farbe { get; set; }
    public Hersteller Hersteller { get; set; }
    public string Modell { get; set; }

    public ModellFahrzeug(Farbe farbe, Hersteller hersteller, string modell)
    {
        Verfuegbar = true;
        Farbe = farbe;
        Hersteller = hersteller;
        Modell = modell;
    }
        
    
    public string Verkaufen()
    {
        return Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde verkauft.";
    }
    public string Reparieren()
    {
        return Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde repariert.";
    }

    public string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return Modell + " vom Hersteller " + Hersteller + " hat nun die Farbe " + Farbe + ".";
    }

    public abstract bool Verleihen();
    public abstract bool Zurueckgeben();

    public string ToString()
    {
        return Modell + "\nHersteller: " + Hersteller + "\nFarbe: " + Farbe;
    }
}