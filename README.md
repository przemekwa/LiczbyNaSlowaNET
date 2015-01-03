LiczbyNaSłowaNET
================

LiczbyNaSłowaNET to biblioteka, która umożliwia konwersje liczb na odpowiedniki słowne z zachowaniem polskiej gramatyki.

Możliwości biblioteki są następujące:

* Zamiana liczb na odpowiedniki słowne z zachowaniem polskiej gramatyki czyli  {"tysiac","tysiace","tysiecy"},
* Zamiana liczb typu decimal,
* Zamina liczb typu decimal na odpowiedniki walutowe.

Projekt składa się z 2 solucji:

1. LiczbyNaSlowaNET - jest to głowna bliblioteka służąca do zamiany liczb na słowa.
2. LiczbyNaSlowaNET_Testy - jest to biblioteka z teastami.

Szybki start:

Biblioteka LiczbyNaSłowaNET to statyczna klasa NumberToTextConverter z metodą Convert, która przyjmuje liczbę typu int lub decimal i  zwraca string z odpowiednikiem słownym danej liczby.

Przykłady zastosowań z testów dostępnych w projekcie:

* Zamiana liczb na odpowiedniki słowne (zachowana polska gramatyka)
 -  Assert.AreEqual("osiemdziesiat cztery", NumberToTextConverter.Convert(84));
 -  Assert.AreEqual("sto dwadziescia tysiecy trzydziesci", NumberToTextConverter.Convert(120030));
 -  Assert.AreEqual("osiemset dwadziescia cztery tysiace siedemset dwa", NumberToTextConverter.Convert(824702));
 -  Assert.AreEqual("jeden tysiac dwa", NumberToTextConverter.Convert(1002)); 

* Zamiana liczb typu decimal:
 -   Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToTextConverter.Convert(14100.23M));
 -   Assert.AreEqual("trzynascie zero", NumberToTextConverter.Convert(13.0M));

* Zamiana liczn typu decimal na odpowiedniki walutowe:
-  Assert.AreEqual("jeden zloty dwadziescia dwa grosze", NumberToTextConverter.Convert(1.22M, NumberToTextConverter.Currency.PL));
-   Assert.AreEqual("dwa zlote szescdziesiat osiem groszy", NumberToTextConverter.Convert(2.68M, NumberToTextConverter.Currency.PL));
-   Assert.AreEqual("zero zlotych dwanascie groszy", NumberToTextConverter.Convert(0.12M, NumberToTextConverter.Currency.PL));

Biblioteka jest implementacją algorytmu bazującego na prawidłowości, że każda liczba składa się z trzy cyfrowych elementów oddzielonych rzędami wielkości.

Szczegóły tutaj: http://www.algorytm.org/inne/zamiana-liczby-na-slowa-z-polska-gramatyka.html

