Team: Victoria Natalie Potok, Nadine Resch, Alexander Zimmermann, Sebastian Hutter
<br>
Version: 1.0.0
<br>
Lizenz: Open Source
<br>
Systemvorraussetzung: .NET 7
<br>

# Modell-Fahrzeug Webshop

## Beschreibung
Dieses Programm dient zur Simulation einer Modellfahrzeug Website, bei der Modell-Flugzeuge & -Autos ausgeliehen, gekauft und repariert werden können. Der User verbindet sich durch Eingabe des Hostnames der Website auf der CMD zur Website, bei der die Verfügbarkeit der Modelle abgerufen werden kann, sowie Bestellungen, Reperaturen und Verleihungen entgegen genommen werden können. Nach dem Verbindungsaufbau zur Website fragt diese was der User auswählen möchte (Verleih, Verkauf, Reperatur). Anschließend steht es dem User frei nach Herstellern und Modellen zu suchen und auszuwählen. Wenn ein Modell ausgehliehen wird, ist dieses für die Zeit in der es verliehen wurde nicht zum Kauf verfügbar. Sobald das Modell automatisch wieder zurückgegeben wurde, ist es wieder im Lagerbestand und somit verfügbar.

## Aufbau
Der Client verbindet sich mit der Website bei der dahinter ein Webservice läuft, welcher die Requests verarbeitet. Dieser ist verbunden mit der Datenbank in welcher der Lagerbestand der Modellfahrzeuge abgespeichert ist. Der Webservice greift auf diese Daten zu um sie der Website und somit dem Client zu Verfügung zu stellen. 

## User Manual
Projekt runnen -> Website.cs wird ausgeführt
<br>
!WICHTIG!: URL & Port <u>exakt</u> eingeben
<br>
URL: webshop.at
<br> 
Port: 443
<br>
<br>
Es folgt ein Menü, in welcher der User anhand der Zahleneingabe auswählen kann, ob der User zum Verkauf, Verleih oder zur Reperatur möchte.
<br>
<br>
Nach der Auswahl werden verfügbare Hersteller und Farben angezeigt. Der User kann anschließend seine Auswahl eingeben. Im Zuge dessen wird ausgegeben ob die Auswahl verfügbar ist oder nicht. 

### Auswahl Verleih
Sobald Hersteller und Farbe ausgewählt wurde und diese verfügbar sind, kann eingegeben werden wielang die Auswahl verliehen werden möchte. Nach der Eingabe kommt die Bestätigung dass das Obkjekt verliehen wurde.
### Auswahl Verkauf
Wenn die Auswahl von Hersteller und Farbe verfügbar ist, wird die Auswahl gekauft und es wird eine Kaufbestätigung ausgegeben.
### Auswahl Reperatur
Wenn die Auswahl von Hersteller und Farbe getroffen wurde, wird eine Reperaturbestätigung ausgegeben.

## Unit-Tests
### Kauf-Test
Mithilfe zweier Unit Tests wird die korrekte Funktionalität des Kaufvorgangs überprüft in dem der Autobestand vor dem Kauf auf Korrektheit überprüft wird und der Autobestand nach dem Kauf auf Korrektheit überprüft wird.
### Verleih-Test
Mithilfer von drei Unit Tests wird die korrekte Funktionalität des Verleihvorgangs überprüft in dem der Autobestand von dem Verleih auf Korrektheit überprüft wird und der Autobestand nach dem Verleih auf Korrektheit überprüft wird. Zudem wird nach Ablauf der Verleihzeit geprüft ob der Autobestand korrekt aktualisiert wurde indem das verliehene Auto "zurückgegegeben" wurde.
<br>
<br>
In Summe bilden sich daher 5 Unit Tests.

## Klassendiagramm
![Klassendiagramm](https://www.plantuml.com/plantuml/png/tPJFRjim3CRlVWeTCwp1TZQAe0coj3rqBPAYEGmxq3PZ2v6bGgAw8K7UVLGCrtywRm6604ClaIn-v4V-9EJA4LZofOhSLkfdi52AL85pKo8h4qzucngzaZiKdoEf2Uq6KXItToP3jO32xj3dOXy9yN4FYICBAHsUq6x1Rr2FFiI2pwJEku8bifD4Ewpu8lK6q2Qis00liLY4PK3DXWfbmMA7QIoa9XOcngYkxD6iZiajqqDKHwknHNSmMJuhB56JwuqS9XwpxSPZde2jtCJbPOxqoI5D9Y6-Q7NUZzsWTOHA8USs-xxgwAdgRdlHSnElL6T0tY8zzMG4_YJKMP_zVu5u0EmGpfCW_X7Ttu0jbCy3ddD04--HsdnMGL7I4TQSCEvo2pMcElJS-yEv46NGrLKlHD7W6UZojKfLEgugV8KIEygLJuiJP4_65g2p4vGDtTCdQ2xuBRWr9WxjYqpno6yEX7e6UXipqk1tZJHwxQGfNo8LVFfREW_6qRyrnqNcg93mhVN0199m7zB4pVtgiLr7FDml-K1g2byS04lX_RmOcHrFzdn4CZsK8FMeollsNO3DNQqwH15gNxOw5S5hThVctwdFPFWmM1bEfKsygtEg-ODwbHO_mEvujqRf7A_Ng9AmM8ywL53WULaQucH-pkFnfFTwwq53g7LlKRFbGBYsAzIPBzKl)
