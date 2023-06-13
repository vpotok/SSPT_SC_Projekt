using System.Threading.Channels;

namespace Projekt_Team7;

public class Webseite
{
    public string Host { get; set; } = "webshop.at";
    public int Port { get; set; } = 443;
    private Webservice webservice = new Webservice();


    public void FarbeAusgabe()
    {
        for (int i = 0; i < Enum.GetValuesAsUnderlyingType(typeof(Farbe)).Length; i++)
        {
            Console.WriteLine((Farbe)(i));
        }
    }
    
    public void HerstellerAusgabe()
    {
        for (int i = 0; i < Enum.GetValuesAsUnderlyingType(typeof(Hersteller)).Length; i++)
        {
            Console.WriteLine((Hersteller)(i));
        }
    }
    

    static void Main(string[] args)
    {
        Webseite webseite = new Webseite();
        try
        {
            Console.WriteLine("------------------");
            Console.Write("URL: ");
            string url = Console.ReadLine();
            Console.Write("Port:");
            int port = int.Parse(Console.ReadLine());
            if (url.Equals(webseite.Host) && port == webseite.Port)
            {
                string Modell = "";
                string methode = "";
                string ausg = "";
                while (true)
                {
                    Console.WriteLine("Moegliche Methoden fuer ModellFahrzeug:");
                    Console.WriteLine("Kaufen, Reparieren, Verliehen, Zurueckgeben, Einfaerben");
                    methode = Console.ReadLine();
                    if (methode.Equals("Reparieren") || methode.Equals("Verliehen") || methode.Equals("Zurueckgeben" ))
                    {
                        Console.Write("Model: ");
                        model = Console.ReadLine(); 
                        ausg = webseite.webservice.Get(model,methode);
                        Console.WriteLine(ausg);
                    }else if (methode.Equals("Kaufen"))
                    {
                        Console.Write("Model: ");
                        model = Console.ReadLine(); 
                        
                        ausg = webseite.webservice.Delete(model);
                        Console.WriteLine(ausg);
                    }else if (methode.Equals("Einfaerben"))
                    {
                        Console.Write("Model: ");
                        model = Console.ReadLine();
                        Console.WriteLine("Verfuegbare Farben:");
                        Console.WriteLine("+++++++++++++++++++++++");
                        webseite.FarbeAusgabe();
                        Console.Write("Farbe: ");
                        int farbe = int.Parse(Console.ReadLine());
                        ausg = webseite.webservice.Put(farbe, model);
                        Console.WriteLine(ausg);
                    }

                    break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}