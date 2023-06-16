namespace Projekt_Team7;

public class ModellFlugzeug : ModellFahrzeug
{
    public ModellFlugzeug(Farbe farbe, Hersteller hersteller, string Modell) : base(farbe, hersteller, Modell)
    {
        ModellArt = "Flugzeug";
    }
    
    public override string Verkaufen()
    {
        string ausg = "";
        if (Verfuegbar)
        {
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde verkauft.";;
        }
        else
        {
            ausg = "Das ModellFlugzeug" + Modell + " konnte nicht verkauft werden.";
        }
        
        return ausg;
    }

    public override string Reparieren()
    {
        string ausg = "";
        if (Verfuegbar)
        {
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde repariert.";
        }
        else
        {
            ausg = "Das ModellFlugzeug" + Modell + " konnte nicht repariert werden.";
        }

        return ausg;
    }

    public override string Einfaerben(Farbe farbe)
    {
        string ausg = "";
        if (Verfuegbar)
        {
            Farbe = farbe;
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " hat nun die Farbe " + Farbe + ".";
        }
        else
        {
            ausg = "Das ModellFlugzeug" + Modell + " konnte nicht eingefaerbt werden.";
        }
        return ausg;
    }

    public override string Verleihen()
    {
        string ausg = "";
        if (Verfuegbar)
        {
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe "+Farbe+" wird verliehen.";
            Verfuegbar = false;
        }
        else
        {
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " konnte nicht verliehen werden.";
        }
        
        return ausg;
    }

    public override string Zurueckgeben()
    {
        string ausg = "";
        if (!Verfuegbar)
        {
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde zurueckgegeben.";
            Verfuegbar = true;
        }
        else
        {
            ausg = "Das ModellFlugzeug " + Modell + " vom Hersteller " + Hersteller + " mit der Farbe " + Farbe + " wurde zurueckgegeben.";
        }
        
        return ausg;
    }

    public string ToString()
    {
        return base.ToString();
    }
}