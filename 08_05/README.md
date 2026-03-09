## 08.05
*Deze oefening is een uitbreiding op oefening 04.05*

Lees 2 getallen in. We veronderstellen dat het eerste getal groter is dan het tweede getal. Geef alle even getallen die tussen het grootste en het kleinste getal liggen.

Werk eerst volgende verplichte methodes uit:

`int ReadNumber()`
: Deze methode vraagt de gebruiker om een geheel getal in te geven. Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald. Returnwaarde is het ingegeven getal.

`bool IsEven(int number)`
: Deze methode controleert of het ingegeven getal even is. Returnwaarde is true als dit het geval is.

`List<int> GetEvenNumberBetween(int n1, int n2)`
: Deze methode bepaalt alle even getallen die tussen het eerste en end tweede getal liggen. Returnwaarde is een lijst van al deze getallen.

`void PrintResult(List<int> numbers)`
: Deze methode toont het resultaat in het juiste formaat. Bekijk de voorbeelden.
