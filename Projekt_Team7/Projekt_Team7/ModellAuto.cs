namespace Projekt_Team7;

public class ModellAuto : ModellFahrzeug
{
    
    
    public ModellAuto(Farbe farbe, Hersteller hersteller, string modell) : base(farbe, hersteller, modell)
    {
        ModellArt = "Auto";
    }
    public override string Verkaufen()
    {
        string ausg = "";
        if (Verfuegbar)
        {
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde verkauft.";;
        }
        else
        {
            ausg = "Das ModellAuto" + Modell + " konnte nicht verkauft werden";
        }
        return ausg;
    }

    public override string Reparieren()
    {
        string ausg = "";
        if (Verfuegbar)
        {
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe +
                   " wurde repariert.";
        }
        else
        {
            ausg = "Das ModellAuto" + Modell + " konnte nicht repariert werden";
        }

        return ausg;
    }

    public override string Einfaerben(Farbe farbe)
    {
        string ausg = "";
        if (Verfuegbar)
        {
            Farbe = farbe;
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " hat nun die Farbe " + Farbe + ".";
        }
        else
        {
            ausg = "Das ModellAuto "+Modell+" konnte nicht eingefaerbt werden.";
        }
        return ausg;
    }

    public override string  Verleihen()
    {
        string ausg = "";
        if (Verfuegbar)
        {
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe "+Farbe+" wird verliehen.";
            Verfuegbar = false;
        }
        else
        {
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " konnte nicht verliehen werden.";
        }
        
        return ausg;
    }

    public override string Zurueckgeben()
    {
        string ausg = "";
        if (!Verfuegbar)
        {
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde zurueckgegeben.";
            Verfuegbar = true;
        }
        else
        {
            ausg = "Das ModellAuto " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " konnte nicht zurueckgegeben werden.";
        }
        
        return ausg;
    }

    public  string ToString()
    {
        return base.ToString();
    }
}