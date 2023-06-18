using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projekt_Team7.Tests
{
    [TestClass()]
    public class WebseiteTests
    {
        string adresse = "webshop.at";
        string port = "443";
        string fahrzeug = "Auto";
        string modellA4 = "A4";
        string modellA7 = "A7";
        string kaufen = "Kaufen";
        string einfaerben = "Einfaerben";
        string verleihen = "Verleihen";
        string modellE46 = "E46";

        [TestMethod()]
        public void Kauftest()
        {

            Webseite webseite = new Webseite();

            using (var stringReader = new StringReader($"webshop.at{Environment.NewLine}443{Environment.NewLine}Kaufen{Environment.NewLine}Auto{Environment.NewLine}{modellA4}{Environment.NewLine}Close{Environment.NewLine}"))
            {
                Console.SetIn(stringReader);
                using (var stringWriter = new StringWriter())
                {
                    Console.SetOut(stringWriter);

                    webseite.start();

                    string output = stringWriter.ToString();
                    Assert.IsTrue(output.Contains($"Das ModellAuto {modellA4} vom Hersteller Audi mit der Farbe Schwarz wurde verkauft."));
                }
            }

        }

        [TestMethod()]
        public void Verleihen_Test()
        {

            Webseite webseite = new Webseite();

            using (var stringReader = new StringReader($"webshop.at{Environment.NewLine}443{Environment.NewLine}Verleihen{Environment.NewLine}Auto{Environment.NewLine}{modellA7}{Environment.NewLine}Close{Environment.NewLine}"))
            {
                Console.SetIn(stringReader);
                using (var stringWriter = new StringWriter())
                {
                    Console.SetOut(stringWriter);

                    webseite.start();

                    string output = stringWriter.ToString();
                    //Assert.IsTrue(output.Contains($"Das ModellAuto {modellA4} vom Hersteller Audi mit der Farbe Blau konnte nicht verliehen werden."));
                    Assert.IsTrue(output.Contains($"Das ModellAuto {modellA7} vom Hersteller Audi mit der Farbe Weiss wird verliehen."));
                }
            }
        }
        [TestMethod()]
        public void Einfaerben_Test()
        {

            Webseite webseite = new Webseite();

            using (var stringReader = new StringReader($"webshop.at{Environment.NewLine}443{Environment.NewLine}Einfaerben{Environment.NewLine}A7{Environment.NewLine}0{Environment.NewLine}Close{Environment.NewLine}"))
            {
                Console.SetIn(stringReader);
                using (var stringWriter = new StringWriter())
                {
                    Console.SetOut(stringWriter);

                    webseite.start();

                    string output = stringWriter.ToString();
                    Assert.IsTrue(output.Contains($"Das ModellAuto A7 vom Hersteller Audi hat nun die Farbe Blau."));
                }
            }


        }
    }
}