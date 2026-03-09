## 08.04
*Deze oefening is een uitbreiding op oefening 06.02*

Lees de familie- en voornaam van de gebruiker in. Controleer dat de invoer ingevuld is.

Lees de hobby van de gebruiker in aan de hand van het bijhorende nummer. Vervolgens krijgt de gebruiker opnieuw de optie om een hobby in te geven. Dit blijft gebeuren tot de gebruiker een 8 ingeeft. 

Hierna wordt een lijst aan suggesties voor tijdschriften getoond. Gebruik hiervoor onderstaande tabel.

Werk eerst volgende verplichte methodes uit:

`string ReadName(string prompt)`
: Deze methode vraagt de gebruiker om een naam in te geven. De parameter dient om een vraag mee te geven die getoond wordt aan de gebruiker. Returnwaarde is ingegeven waarde. Controleer dat de input geldig is.

`int ReadHobby(int min, int max)`
: Deze methode vraagt de gebruiker om een geheel getal in te geven binnen de bepaalde grenzen. Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald. Returnwaarde is het ingegeven getal.

`void RecommendBooks(List<int> hobbies)`
: Deze methode raadt de tijdschriften aan op basis van de ingegeven hobbies (nummers). Opmerking: je mag in deze methode enkel gebruik maken van een if. Een if-else structuur of switch is niet toegestaan.
