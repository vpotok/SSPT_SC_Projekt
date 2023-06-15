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
    
    public void start()
    {
         Console.WriteLine("------------------");
            Console.Write("URL: ");
            string url = Console.ReadLine();
            Console.Write("Port:");
            int port = int.Parse(Console.ReadLine());
            if (url.Equals(Host) && port == Port)
            {
                string modell = "";
                string methode = "";
                string ausg = "";
                while (true)
                {
                    Console.WriteLine("Moegliche Methoden fuer ModellFahrzeug:");
                    Console.WriteLine("Kaufen, Reparieren, Verliehen, Zurueckgeben, Einfaerben, Close");
                    methode = Console.ReadLine();
                    if (methode.Equals("Reparieren") || methode.Equals("Verliehen") || methode.Equals("Zurueckgeben" ))
                    {
                        Console.Write("Model: ");
                        modell = Console.ReadLine(); 
                        ausg = webservice.Get(modell,methode);
                        Console.WriteLine(ausg);
                    }else if (methode.Equals("Kaufen"))
                    {
                        Console.WriteLine("Welche ModellArt wollen Sie kaufen?\nMoegliche Eingaben: Alle, Auto, Flugzeug");
                        string modellArt = Console.ReadLine();
                        webservice.GET(modellArt);
                        Console.Write("Model: ");
                        modell = Console.ReadLine(); 
                        
                        ausg = webservice.Delete(modell);
                        Console.WriteLine(ausg);
                    }else if (methode.Equals("Einfaerben"))
                    {
                        Console.Write("Model: ");
                        modell = Console.ReadLine();
                        Console.WriteLine("Verfuegbare Farben:");
                        Console.WriteLine("+++++++++++++++++++++++");
                        FarbeAusgabe();
                        Console.Write("Farbe: ");
                        int farbe = int.Parse(Console.ReadLine());
                        ausg = webservice.Put(farbe, modell);
                        Console.WriteLine(ausg);
                    }else if (methode.Equals("Close"))
                    {
                        Console.WriteLine("Connection wurde geschloßen.");
                        break;
                    }

                    
                }
            }
    }
    static void Main(string[] args)
    {
        Webseite webseite = new Webseite();
        try
        {
            
                
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}