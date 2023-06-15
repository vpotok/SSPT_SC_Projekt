namespace Projekt_Team7;

public class DatenBank
{
    private List<ModellFlugzeug> listeFahrzeuge = new List<ModellFlugzeug>();

    
    public string  Hinzufuegen(string art,string Modell, int hersteller, int farbe)
    {
        ModellFlugzeug newm = null;
        switch (art)
        {
            case "Auto":
                newm = new ModellFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), Modell);
                break;
            case "Flugzeug":
                newm = new ModellFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), Modell);
                break;
            default:
                break;
        }

        listeFahrzeuge.Add(newm);
        return newm.ToString();
    }



    public string Verkaufen(string model)
    {
        string ausg = "";
        foreach (ModelFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                ausg = f.Verkaufen();
                listeFahrzeuge.Remove(f);
            }else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }

        return ausg;
    }

    

    public string Suchen(string model)
    {
        string ausg = "";
        foreach (ModelFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                ausg = f.ToString();
                
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg;
    }

    public string Verleihen(string modell)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Equals(modell))
            {
                 bool verliehen = f.Verleihen();
                 if (verliehen)
                 {
                     ausg = f.modell + " wurde verliehen.";
                 }
                 else
                 {
                     ausg = f.Model + " kann nicht verliehen werden.";
                 }
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg;
    }
    
    public string Zurueckgeben(string model)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                bool zurueckgeben = f.Zurueckgeben();
                if (zurueckgeben)
                {
                    ausg = f.Model + " wurde zurueckgegeben.";
                }
                else
                {
                    ausg = f.Model + " kann nicht zurueckgegeben werden.";
                }
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg;
    }

    public string Reparieren(string model)
    {
        string ausg = "";
        foreach (ModelFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                ausg = f.Reparieren();
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg; 
    }
    public string Einfaerben(string model, int farbe)
    {
        string ausg = "";
        foreach (ModelFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                ausg = f.Einfaerben((Farbe)(farbe));
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg; 
    }
}