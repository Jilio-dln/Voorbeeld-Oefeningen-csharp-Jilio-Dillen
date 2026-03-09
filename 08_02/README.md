## 08.02
*Deze oefening is een uitbreiding op oefening 04.04*

Lees 2 symbolen in. Het tweede symbool moet verschillend zijn van het eerste. Na het inlezen van deze symbolen vraag je een lengte en een breedte. Hierna drukt het programma een sjaal af met de ingevoerde waarden. Bekijk de voorbeelden aandachtig.

Werk eerst volgende verplichte methodes uit:

`int ReadNumber()`
: Deze methode vraagt de gebruiker om een geheel getal in te geven. Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald. Returnwaarde is het ingegeven getal.

`string ReadSymbol(string compareSymbol)`
: Deze methode vraagt de gebruiker om een symbool in te geven. Het symbool moet verschillend zijn van het symbool dat meegegeven wordt. Een symbool bestaat uit 1 karakter. Returnwaarde is het ingegeven symbool.

`string MakeLine(string symbol, int length)`
: Deze methode maakt een lijn die bestaat uit x aantal keer het symbool, waarbij x de lengte is. Returnwaarde is de gemaakte lijn.

`string CreateScarf(string line1, string line2, int length)`
: Deze methode maakt de volledige sjaal obv de gemaakte lijnen. Returnwaarde is de volledige sjaal.
