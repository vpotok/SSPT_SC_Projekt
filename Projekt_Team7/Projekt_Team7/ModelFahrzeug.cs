namespace Projekt_Team7;

public abstract class ModelFahrzeug : IModelFahrzeug
{
    public bool Verfuegbar { get; set; } = true;
    public Farbe Farbe { get; set; }
    public Hersteller Hersteller { get; set; }
    public string Model { get; set; }

    public ModelFahrzeug(Farbe farbe, Hersteller hersteller, string model)
    {
        Verfuegbar = true;
        Farbe = farbe;
        Hersteller = hersteller;
        Model = model;
    }
        
    
    public string Verkaufen()
    {
        return Model + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde verkauft.";
    }
    public string Reparieren()
    {
        return Model + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde repariert.";
    }

    public string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return Model + " vom Hersteller " + Hersteller + " hat nun die Farbe " + Farbe + ".";
    }

    public bool Verleihen(int sec)
    {
        return Verfuegbar;
    }
    
    public string ToString()
    {
        return Model + "\nHersteller: " + Hersteller + "\nFarbe: " + Farbe;
    }
}