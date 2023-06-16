namespace Projekt_Team7;

public abstract class ModellFahrzeug : IModellFahrzeug
{
    public bool Verfuegbar { get; set; } = true;
    public Farbe Farbe { get; set; }
    public Hersteller Hersteller { get; set; }
    public string Modell { get; set; }
    public string ModellArt { set; get; } = "none";
    public ModellFahrzeug(Farbe farbe, Hersteller hersteller, string modell)
    {
        Verfuegbar = true;
        Farbe = farbe;
        Hersteller = hersteller;
        Modell = modell;
    }


    public abstract string Verkaufen();
    public abstract string Reparieren();

    public abstract string Einfaerben(Farbe farbe);

    public abstract string Verleihen();
    public abstract string Zurueckgeben();

    public string ToString()
    {
        return "Art: "+ModellArt+" Modell: "+Modell + " Hersteller: " + Hersteller + " Farbe: " + Farbe;
    }
}