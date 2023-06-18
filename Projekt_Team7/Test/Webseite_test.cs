using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using Projekt_Team7;
using System;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace Projekt_Team7
{
    [TestFixture]
    public class WebseiteTests
    {
        [Test]
        public void Start_ShouldExecuteCorrectLogic()
        {
            // Arrange
            var webseite = new Webseite();

            // Set up test inputs
            string url = "webshop.at";
            int port = 443;
            string modellArt = "Auto";
            string modell = "A4";

            // Set up console input for testing
            using (var stringWriter = new StringReader($"{url}{Environment.NewLine}{port}{Environment.NewLine}Kaufen{Environment.NewLine}{modellArt}{Environment.NewLine}{modell}{Environment.NewLine}Close{Environment.NewLine}"))
            {
                Console.SetIn(stringWriter);

                // Act
                webseite.start();

                // Assert
                // Add assertions to verify the expected behavior of the start() method
                Assert.AreEqual("Das ModellAuto A4 vom Hersteller Audi mit der Farbe Schwarz wurde verkauft.", ConsoleOutput.GetOutput());


            }

        }

        // Add more unit tests for other methods in the Webseite class

        // Consider writing tests for error cases and edge cases as well.
    }
}
