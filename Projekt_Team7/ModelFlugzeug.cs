namespace Projekt_Team7;

public class ModelFlugzeug : ModelFahrzeug
{
    public override string Verkaufen()
    {
        return "Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde verkauft.";
    }

    public override string Reparieren()
    {
        return "Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde repariert.";
    }

    public override string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return "Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " hat nun die Farbe "+Farbe+".";
    }

    public override bool Verleihen(int sec)
    {
        Console.WriteLine("Das ModelFlugzeug " + Model + " vom Hersteller " + Hersteller + " mit der Farbe: "+Farbe+" wird fuer "+sec+" Milisekunden verliehen.");
        System.Threading.Thread.Sleep(sec);
        return true;
    }
    
    public override string ToString()
    {
        return "ModelFlugzeug: " + Model + "\nHersteller: " + Hersteller + "\nFarbe: " + Farbe;
    }
}