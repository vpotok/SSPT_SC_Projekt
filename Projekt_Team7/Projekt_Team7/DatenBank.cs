using System.Drawing;

namespace Projekt_Team7;

public class DatenBank
{
    private List<ModellFahrzeug> listeFahrzeuge = new List<ModellFahrzeug>();

    
    public string  Hinzufuegen(string art,string Modell, int hersteller, int farbe)
    {
        ModellFahrzeug newm = null;
        switch (art)
        {
            case "Auto":
                newm = new ModellAuto((Farbe)(farbe), (Hersteller)(hersteller), Modell);
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



    public string Verkaufen(string modell)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Modell.Equals(modell))
            {
                ausg = f.Verkaufen();
                listeFahrzeuge.Remove(f);
                break;
            }else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }

        return ausg;
    }

    

    public string Suchen(string modell)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Modell.Equals(modell))
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
            if (f.Modell.Equals(modell))
            {
                ausg = f.Verleihen();
                break;
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg;
    }
    
    public string Zurueckgeben(string modell)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Modell.Equals(modell))
            {
                ausg = f.Zurueckgeben();
                break;
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg;
    }

    public string Reparieren(string modell)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Modell.Equals(modell))
            {
                ausg = f.Reparieren();
                break;
            }
            else
            {
                ausg = "Modell nicht verfuegbar!";
            }
        }
        return ausg; 
    }
    public string Einfaerben(string modell, int farbe)
    {
        string ausg = "";
        foreach (ModellFahrzeug f in listeFahrzeuge)
        {
            if (f.Modell.Equals(modell))
            {
                ausg = f.Einfaerben((Farbe)(farbe));
                break;
            }
            else
            {
                ausg = "Model nicht verfuegbar!";
            }
        }
        return ausg; 
    }

    public string Verfuegbar(string ModellArt)
    {
        string ausg = "Liste aller Verfuebaren Modelle:\n";
        
        switch (ModellArt)
        {
            case "Alle":
                foreach (ModellFahrzeug allF in listeFahrzeuge)
                {
                    if (allF.Verfuegbar)
                    {
                        ausg += "\n" + allF.ToString();
                    }
                }
                break;
            case "Auto":
                foreach (ModellFahrzeug fa in listeFahrzeuge)
                {
                    
                    if (fa.ModellArt.Equals(ModellArt) && fa.Verfuegbar)
                    {
                        ausg += "\n" + fa.ToString();
                    }
                }
                break;
            case "Flugzeug":
                foreach (ModellFahrzeug ff in listeFahrzeuge)
                {
                    if (ff.ModellArt.Equals(ModellArt) && ff.Verfuegbar)
                    {
                        ausg += "\n" + ff.ToString();
                    }
                }
                break;
            default:
                break;
        }

        
        return ausg;
    }

    
}