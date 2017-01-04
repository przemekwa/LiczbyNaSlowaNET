LiczbyNaSłowaNET [![NuGet Version](https://img.shields.io/nuget/v/LiczbyNaSlowaNET.dll.svg?style=flat)](https://www.nuget.org/packages/LiczbyNaSlowaNET.dll/) ![Build] (https://api.travis-ci.org/przemekwa/LiczbyNaSlowaNET.svg?branch=master)  [![Join the chat at https://gitter.im/LiczbyNaSlowaNET/Lobby?source=orgpage](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/LiczbyNaSlowaNET/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
=================
 

LiczbyNaSłowaNET to biblioteka, która umożliwia konwersje liczb na odpowiedniki słowne z zachowaniem polskiej gramatyki.

Biblioteka dostępna przez nuget-y: https://www.nuget.org/packages/LiczbyNaSlowaNET.dll/

Możliwości biblioteki są następujące:

* Zamiana liczb na odpowiedniki słowne z zachowaniem polskiej gramatyki czyli  {"tysiac","tysiace","tysiecy"},
* zamiana liczb typu decimal i int,
* zamiana liczb typu decimal na odpowiedniki walutowe,
* definiowanie własnego separatora liczb typu decimal.
* możliwość ustawiania dowolnej waluty, podczas konwersji liczby na odpowiednik walutowy (ta funkcjonalność powstała dzięki wsparciu społeczności w szcególności użytkownika s13n4 - Tomasz Sienkiewicz). Przykłady znajdują się na dole.

Projekt składa się z 2 solucji:

1. LiczbyNaSlowaNET - jest to głowna bliblioteka służąca do zamiany liczb na słowa.
2. LiczbyNaSlowaNET_Testy - jest to biblioteka z testami.

##Wersja 1.0.0.5

Dzięki wsparciu https://github.com/ZmorzynskiK biblioteka dorobiła się kolejne wersji i sporo przydatnych zmian w kodzie

+ dodanie pomocniczych metod do NumberToText
+ przejście z int na long (potencjalnie większy zakres)
+ usunięcie kilku klas (np NumberToTextOptionBuilder), w ich miejsce inne wywołania
+ zmiany w architekturze klasy CurrencyAlgorithm
+ uproszczenie interfejsów
+ wspólna bazowa klasa BaseCurrencyDeflation
+ dostosowanie słowników-deflacji do zmienionego interfejsu ICurrencyDeflation

##Wersja 1.0.0.4

+ usunięcie kontenera DI.
+ biblioteka już nie potrzebuje zależności innych niż .NET 4.0
+ możliwość ustawiania czy tekst ma posadać polskie znaki czy też nie. Domyślnie jest bez polskich znaków. 
+ możliwość podmienienia słowników zawierających liczebniki.
+ dodanie obsługi wartości procentowych

Przykładowe wywołanie i ustawienie słownika z polskimi znakami. 

            var options = new NumberToTextOptions
            {
                Stems = true,
                Currency = Currency.PLN,
            };

            Assert.Equal("sześć złotych czterdzieści dziewięć groszy", NumberToText.Convert(6.486M, options));
            

### Szybki start:

Biblioteka LiczbyNaSłowaNET to statyczna klasa NumberToText z metodą Convert, która przyjmuje liczbę typu int lub decimal i zwraca string z odpowiednikiem słownym danej liczby. Dodatkowo można przesłać obiekt NumberToTextOptions, w którym definiujemy walutę i separator liczb dziesiętnych.

Przykłady zastosowań z testów dostępnych w projekcie:

* Zamiana liczb na odpowiedniki słowne (zachowana polskiej gramatyki)
 -  Assert.AreEqual("osiemdziesiat cztery", NumberToText.Convert(84));
 -  Assert.AreEqual("sto dwadziescia tysiecy trzydziesci", NumberToText.Convert(120030));
 -  Assert.AreEqual("osiemset dwadziescia cztery tysiace siedemset dwa", NumberToText.Convert(824702));
 -  Assert.AreEqual("jeden tysiac dwa", NumberToText.Convert(1002)); 

* Zamiana liczb typu decimal:
 -   Assert.AreEqual("czternascie tysiecy sto dwadziescia trzy", NumberToText.Convert(14100.23M));
 -   Assert.AreEqual("trzynascie zero", NumberToText.Convert(13.0M));

* Zamiana liczb typu decimal na odpowiedniki walutowe:
 - Assert.AreEqual("jeden zloty dwadziescia dwa grosze", NumberToText.Convert(1.22M,  NumberToText.Currency.PL));
 -   Assert.AreEqual("dwa zlote szescdziesiat osiem groszy", NumberToText.Convert(2.68M, NumberToText.Currency.PL));
 -   Assert.AreEqual("zero zlotych dwanascie groszy", NumberToText.Convert(0.12M, NumberToText.Currency.PL));
 
* Można również przesłać własny string, który rozdzieli liczby po przecinku.

 ```var options = new NumberToTextOptions
            {
                curency = Currency.PL,
                SplitDecimal = "i"
            };```

Assert.AreEqual("dwanascie zlotych i dwadziescia trzy grosze", NumberToText.Convert(12.23M, options));


* Możliwość konwersji liczby na odpowiednik walutowy z możliwością wyboru waluty.

 - Assert.Equal("trzynascie euro zero centow", NumberToText.Convert(13.0M, Currency.EUR)); 
 - Assert.Equal("piec funtow brytyjskich zero pensow", NumberToText.Convert(5.00M, Currency.GBP));
 - Assert.Equal("piec koron czeskich zero halerzy", NumberToText.Convert(5.00M, Currency.CZK));
            
Obecnie biblioteka wspiera nastepujące waluty:

```public enum Currency
    {
        NONE,
        PLN,
        CHF,
        CZK,
        EUR,
        HUF,
        JPY,
        LTL,
        NOK,
        SEK,
        USD,
        GBP,
        PERCENT // nie było lepszego miejsca. To jest wartość procentowa np: sześć procent
    }```

Biblioteka jest bezpieczna w środowisku wielowątkowym(ThreadSafety)

Opis biblioteki znajduje się również na moim blogu: http://blogprogramisty.net/zamiana-liczby-na-slowa-z-polska-gramatyka-c/

Biblioteka jest implementacją algorytmu bazującego na prawidłowości, że każda liczba składa się z trzy cyfrowych elementów oddzielonych rzędami wielkości.

Szczegóły tutaj: http://www.algorytm.org/inne/zamiana-liczby-na-slowa-z-polska-gramatyka.html

