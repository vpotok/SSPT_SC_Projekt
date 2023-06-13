namespace Projekt_Team7;

public interface IModellFahrzeug
{
    public string Verkaufen();
    public string Reparieren();
    public string Einfaerben(Farbe farbe);
    public bool Verleihen();
    public bool Zurueckgeben();

    public string ToString();
}