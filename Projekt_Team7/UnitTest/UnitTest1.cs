using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Projekt_Team7;
using Projekt_Team7.Webseite;



namespace Projekt_Team7
{
    [TestClass]
    public class Webseite_test
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

        [TestMethod]
        public void Kauftest()
        {
            var webseite = new Webseite();

            using (var stringReader = new StringReader($"{adresse}\n{port}\n{kaufen}\n{fahrzeug}\n{modellA4}\n"))
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

        [TestMethod]
        public void Verleihen_Test()
        {
            var webseite = new Webseite();

            using (var stringReader = new StringReader($"{verleihen}\n{modellA4}\n{verleihen}\n{modellA7}\n"))
            {
                Console.SetIn(stringReader);

                using (var stringWriter = new StringWriter())
                {
                    Console.SetOut(stringWriter);

                    webseite.start();

                    string output = stringWriter.ToString();
                    Assert.IsTrue(output.Contains($"Das ModellAuto {modellA4} vom Hersteller Audi mit der Farbe Blau konnte nicht verliehen werden."));
                    Assert.IsTrue(output.Contains($"Das ModellAuto {modellA7} vom Hersteller Audi mit der Farbe Weiß wird verliehen."));
                }
            }
        }

        [TestMethod]
        public void Einfaerben_Test()
        {
            var webseite = new Webseite();

            using (var stringReader = new StringReader($"{einfaerben}\n{modellE46}\n0\n"))
            {
                Console.SetIn(stringReader);

                using (var stringWriter = new StringWriter())
                {
                    Console.SetOut(stringWriter);

                    webseite.start();

                    string output = stringWriter.ToString();
                    Assert.IsTrue(output.Contains($"Das ModellAuto {modellE46} vom Hersteller BMW hat nun die Farbe Blau."));
                }
            }
        }
    }
}
