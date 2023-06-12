namespace Projekt_Team7;

public abstract class ModelFahrzeug : IModelFahrzeug
{
    public bool Verfuegbar { get; set; } = true;
    public Farbe Farbe { get; set; }
    public Hersteller Hersteller { get; set; }
    public string Model { get; set; }

    public abstract string Verkaufen();
    public abstract string Reparieren();

    public abstract string Einfaerben(Farbe farbe);

    public abstract bool Verleihen(int sec);
    
    public abstract string ToString();
}