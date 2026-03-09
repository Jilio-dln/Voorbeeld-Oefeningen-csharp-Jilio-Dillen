## 08.01
*Deze oefening is een uitbreiding op oefening 03.01*

Er moeten 3 gehele getallen ingelezen worden, één lettercode 'A' of 'B' en een cijfercode '1', '2' of '3'. De combinatie van de lettercode en de cijfercode bepalen welke bewerking er moet uitgevoerd worden. Bekijk onderstaande tabel aandachtig om de juiste bewerking te achterhalen.


Werk eerst volgende verplichte methodes uit:

`int ReadNumber()`.
: Deze methode vraagt de gebruiker om een geheel getal in te geven. Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald. Returnwaarde is het ingegeven getal.

`string ReadLetter()`.
: Deze methode vraagt de gebruiker om een letter in te lezen. Deze vraag blijft herhalen tot de gebruiker "A" of "B" ingeeft. Returnwaarde is dus "A" of "B".

`int Sum(int x, int y)`.
: Deze methode heeft als returnwaarde de som van beide parameters.

`int Subtract(int x, int y)`.
: Deze methode heeft als returnwaarde het verschil van beide parameters.

`void PrintResult(int n1, int n2, string operation, int result)`.
: Deze methode zonder returnwaarde print het resultaat. de parameter *operation* bevat het teken dat bij de uitgevoerde operatie hoort. Bekijk de voorbeelden voor de correcte uitvoer.
