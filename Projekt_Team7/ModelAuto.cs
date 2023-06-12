namespace Projekt_Team7;

public class ModelAuto : ModelFahrzeug
{
    public override string Verkaufen()
    {
        return "Das ModelAuto " + Model + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde verkauft.";
    }

    public override string Reparieren()
    {
        return "Das ModelAuto " + Model + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde repariert.";
    }

    public override string Einfaerben(Farbe farbe)
    {
        Farbe = farbe;
        return "Das ModelAuto " + Model + " vom Hersteller " + Hersteller + " hat nun die Farbe "+Farbe+".";
    }

    public override bool Verleihen(int sec)
    {
        Console.WriteLine("Das ModelAuto " + Model + " vom Hersteller " + Hersteller + " mit der Farbe: "+Farbe+" wird fuer "+sec+" Milisekunden verliehen.");
        System.Threading.Thread.Sleep(sec);
        return true;
    }

    public override string ToString()
    {
        return "ModelAuto: " + Model + "\nHersteller: " + Hersteller + "\nFarbe: " + Farbe;
    }
}