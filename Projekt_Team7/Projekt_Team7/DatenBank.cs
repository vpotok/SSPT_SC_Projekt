namespace Projekt_Team7;

public class DatenBank
{
    private List<ModelFahrzeug> listeFahrzeuge = new List<ModelFahrzeug>();

    
    public string Hinzufuegen(string art,string model, int hersteller, int farbe)
    {
        ModelFlugzeug newm = null;
        switch (art)
        {
            case "Auto":
                newm = new ModelFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), model);
                break;
            case "Flugzeug":
                newm = new ModelFlugzeug((Farbe)(farbe), (Hersteller)(hersteller), model);
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

    public string Verleihen(string model, int sec)
    {
        string ausg = "";
        foreach (ModelFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                 bool verliehen = f.Verleihen(sec);
                 if (verliehen)
                 {
                     ausg = f.Model + " wurde verliehen.";
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
        foreach (ModelFahrzeug f in listeFahrzeuge)
        {
            if (f.Model.Equals(model))
            {
                //bool verliehen = f;
                if (verliehen)
                {
                    ausg = f.Model + " wurde verliehen.";
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
}