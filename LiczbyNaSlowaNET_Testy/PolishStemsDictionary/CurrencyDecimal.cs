
// Copyright (c) 2014 Przemek Walkowski

using System;

using LiczbyNaSlowaNET;
using System.Globalization;
using LiczbyNaSlowaNET.Dictionaries;

using LiczbyNaSlowaNET.Dictionaries.Currencies;

using Xunit;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{
    using System.Collections.Generic;

    public class CurrencyDecimal :TestBase
    {
       [Fact]
        public void Test_Currency_6_486()
       {

           Assert.Equal("sześć złotych czterdzieści dziewięć groszy", NumberToText.Convert(6.486M, new NumberToTextOptions
           {
               Currency = new CurrencyDeflationFactory(true).CreateInstance(Currency.PLN.ToString()),
               Dictionary = new PolishWithsStemsDictionary()
           }));

       }

      // [Fact]
      //  public void Test_Currency_6_414()
      //  {
      //      Assert.Equal("sześć złotych czterdzieści jeden groszy", NumberToText.Convert(6.414M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_6_400()
      //  {
      //      Assert.Equal("sześć złotych czterdzieści groszy", NumberToText.Convert(6.400M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_4_4()
      //  {
      //      Assert.Equal("cztery złote czterdzieści groszy", NumberToText.Convert(4.4M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_4_40()
      //  {
      //      Assert.Equal("cztery złote czterdzieści groszy", NumberToText.Convert(4.40M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_12_23()
      //  {
      //      Assert.Equal("dwanaście złotych dwadzieścia trzy grosze", NumberToText.Convert(12.23M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_12_02()
      //  {
      //      Assert.Equal("dwanaście złotych dwa grosze", NumberToText.Convert(12.02M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_0_12()
      //  {
      //      Assert.Equal("zero złotych dwanaście groszy", NumberToText.Convert(0.12M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_123_12()
      //  {
      //      Assert.Equal("sto dwadzieścia trzy złote dwanaście groszy", NumberToText.Convert(123.12M, CreateNumberToTextOption("PLN")));
      //  }


      // [Fact]
      //  public void Test_Currency_125_12()
      //  {
      //      Assert.Equal("sto dwadzieścia pięć złotych dwanaście groszy", NumberToText.Convert(125.12M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_126_12()
      //  {
      //      Assert.Equal("sto dwadzieścia sześć złotych dwanaście groszy", NumberToText.Convert(126.12M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_23_12()
      //  {
      //      Assert.Equal("dwadzieścia trzy złote dwanaście groszy", NumberToText.Convert(23.12M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_Infinity()
      //  {
      //      Assert.Equal("", NumberToText.Convert(999999999999999999999M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_13_0()
      //  {
      //      Assert.Equal("trzynaście złotych zero groszy", NumberToText.Convert(13.0M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_2594()
      //  {
      //      Assert.Equal("dwa tysiące pięćset dziewięćdziesiąt cztery złote", NumberToText.Convert(2594, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_4()
      //  {
      //      Assert.Equal("cztery złote", NumberToText.Convert(4, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_2()
      //  {
      //      Assert.Equal("dwa złote", NumberToText.Convert(2, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_2_68()
      //  {
      //      Assert.Equal("dwa złote sześćdziesiąt osiem groszy", NumberToText.Convert(2.68M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_1()
      //  {
      //      Assert.Equal("jeden złoty", NumberToText.Convert(1, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_1_02()
      //  {
      //      Assert.Equal("jeden złoty dwa grosze", NumberToText.Convert(1.02M, CreateNumberToTextOption("PLN")));
      //  }


      //[Fact]
      //  public void Test_Currency_1_22()
      //  {
      //      Assert.Equal("jeden złoty dwadzieścia dwa grosze", NumberToText.Convert(1.22M, CreateNumberToTextOption("PLN")));
      //  }
        
      // [Fact]
      //  public void Test_Currency_0_01()
      //  {
      //      Assert.Equal("zero złotych jeden grosz", NumberToText.Convert(0.01M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_0_20()
      //  {
      //      Assert.Equal("zero złotych dwadzieścia groszy", NumberToText.Convert(0.20M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_5()
      //  {
      //      Assert.Equal("pięć złotych", NumberToText.Convert(5, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_3_99()
      //  {
      //      Assert.Equal("trzy złote dziewięćdziesiąt dziewięć groszy", NumberToText.Convert(3.99M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_999_00()
      //  {
      //      Assert.Equal("dziewięćset dziewięćdziesiąt dziewięć złotych zero groszy", NumberToText.Convert(999.00M, CreateNumberToTextOption("PLN")));
      //  }


      // [Fact]
      //  public void Test_Currency_1000_00()
      //  {
      //      Assert.Equal("jeden tysiąc złotych zero groszy", NumberToText.Convert(1000.00M, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_2320_00()
      //  {
      //      Assert.Equal("dwa tysiące trzysta dwadzieścia złotych zero groszy", NumberToText.Convert(2320.00M, CreateNumberToTextOption("PLN")));
      //  }
        
      // [Fact]
      //  public void Test_Currency_2596()
      //  {
      //      Assert.Equal("dwa tysiące pięćset dziewięćdziesiąt sześć złotych", NumberToText.Convert(2596, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_Currency_20367_40()
      //  {
      //      Assert.Equal("dwadzieścia tysięcy trzysta sześćdziesiąt siedem złotych czterdzieści groszy", NumberToText.Convert(20367.40M, CreateNumberToTextOption("PLN")));
      //  }
      // [Fact]
      //  public void Test_CurrencyEur_100_34()
      //  {
      //      Assert.Equal("sto euro trzydzieści cztery centy", NumberToText.Convert(100.34M, CreateNumberToTextOption("EUR")));
      //  }
      // [Fact]
      //  public void Test_CurrencyChf_100()
      //  {
      //      Assert.Equal("sto franków szwajcarskich", NumberToText.Convert(100, CreateNumberToTextOption("CHF")));
      //  }

      // [Fact]
      //  public void Test_CurrencyPln_535535_53()
      //  {
      //      Assert.Equal("pięćset trzydzieści pięć tysięcy pięćset trzydzieści pięć złotych pięćdziesiąt trzy grosze", NumberToText.Convert(535535.53M, CreateNumberToTextOption("PLN")));
      //  }
      
      //      [Fact]
      //  public void Test_CurrencyPln_535535_53_fromString()
      //  {
      //      var valueToConvert = "535535.53"; 
      //      //var monasConvertedValue = decimal.Parse(valueToConvert.Replace(",", "."));
      //      var numbertoConvert = decimal.Parse(valueToConvert.Replace(",","."), NumberFormatInfo.InvariantInfo);
      //      Assert.Equal("pięćset trzydzieści pięć tysięcy pięćset trzydzieści pięć złotych pięćdziesiąt trzy grosze", NumberToText.Convert(numbertoConvert, CreateNumberToTextOption("PLN")));
      //  }

      // [Fact]
      //  public void Test_CurrencyPln_606015()
      //  {
      //      var valueToConvert = "606015.00";
      //      var numbertoConvert = decimal.Parse(valueToConvert.Replace(",", "."), NumberFormatInfo.InvariantInfo);
      //      Assert.Equal("sześćset sześć tysięcy piętnaście złotych zero groszy", NumberToText.Convert(numbertoConvert, CreateNumberToTextOption("PLN")));
      //  }
      // [Fact]
      //  public void Test_CurrencyPln_9696_24()
      //  {
      //      var valueToConvert = "9696,24";
      //      var numbertoConvert = decimal.Parse(valueToConvert.Replace(",", "."), NumberFormatInfo.InvariantInfo);
      //      Assert.Equal("dziewięć tysięcy sześćset dziewięćdziesiąt sześć złotych dwadzieścia cztery grosze", NumberToText.Convert(numbertoConvert, CreateNumberToTextOption("PLN")));
      //  }
      // [Fact]
      //  public void Test_CurrencyCZK_1()
      //  {
      //      Assert.Equal("jedna korona czeska", NumberToText.Convert(1, CreateNumberToTextOption("CZK")));
      //  }
      // [Fact]
      //  public void Test_CurrencyCZK_2()
      //  {
      //      Assert.Equal("dwie korony czeskie", NumberToText.Convert(2, CreateNumberToTextOption("CZK")));
      //  }
      // [Fact]
      //  public void Test_CurrencyCZK_5()
      //  {
      //      Assert.Equal("pięć koron czeskich zero halerzy", NumberToText.Convert(5.00M, CreateNumberToTextOption("CZK")));
      //  }
      // [Fact]
      //  public void Test_CurrencyGBP_1()
      //  {
      //      Assert.Equal("jeden funt brytyjski", NumberToText.Convert(1, CreateNumberToTextOption( "GBP")));
      //  }
      // [Fact]
      //  public void Test_CurrencyGBP_2()
      //  {
      //      Assert.Equal("dwa funty brytyjskie", NumberToText.Convert(2, CreateNumberToTextOption("GBP")));
      //  }
      // [Fact]
      //  public void Test_CurrencyGBP_5()
      //  {
      //      Assert.Equal("pięć funtów brytyjskich zero pensów", NumberToText.Convert(5.00M, CreateNumberToTextOption("GBP")));
      //  }
      // [Fact]
      //  public void Test_CurrencyHUF_1()
      //  {
      //      Assert.Equal("jeden forint", NumberToText.Convert(1, Currency.HUF));
      //  }
      // [Fact]
      //  public void Test_CurrencyHUF_2()
      //  {
      //      Assert.Equal("dwa forinty", NumberToText.Convert(2, Currency.HUF));
      //  }
      // [Fact]
      //  public void Test_CurrencyHUF_5()
      //  {
      //      Assert.Equal("pięć forintów zero", NumberToText.Convert(5.00M, CreateNumberToTextOption("HUF")));
      //  }
      // [Fact]
      //  public void Test_CurrencyJPY_1()
      //  {
      //      Assert.Equal("jeden jen", NumberToText.Convert(1, CreateNumberToTextOption("JPY")));
      //  }
      // [Fact]
      //  public void Test_CurrencyJPY_2()
      //  {
      //      Assert.Equal("dwa jeny", NumberToText.Convert(2, CreateNumberToTextOption("JPY")));
      //  }
      // [Fact]
      //  public void Test_CurrencyJPY_5()
      //  {
      //      Assert.Equal("pięć jenów zero", NumberToText.Convert(5.00M, CreateNumberToTextOption("JPY")));
      //  }
      // [Fact]
      //  public void Test_CurrencyLTL_1()
      //  {
      //      Assert.Equal("jeden lit litewski", NumberToText.Convert(1, CreateNumberToTextOption( "LTL")));
      //  }
      // [Fact]
      //  public void Test_CurrencyLTL_2()
      //  {
      //      Assert.Equal("dwa lity litewskie", NumberToText.Convert(2, CreateNumberToTextOption("LTL")));
      //  }
      // [Fact]
      //  public void Test_CurrencyLTL_5()
      //  {
      //      Assert.Equal("pięć litów litewskich zero centów", NumberToText.Convert(5.00M, CreateNumberToTextOption( "LTL")));
      //  }
      // [Fact]
      //  public void Test_CurrencyNOK_1()
      //  {
      //      Assert.Equal("jedna korona norweska", NumberToText.Convert(1, CreateNumberToTextOption("NOK")));
      //  }
      // [Fact]
      //  public void Test_CurrencyNOK_2()
      //  {
      //      Assert.Equal("dwie korony norweskie", NumberToText.Convert(2, CreateNumberToTextOption("NOK")));
      //  }
      // [Fact]
      //  public void Test_CurrencyNOK_5()
      //  {
      //      Assert.Equal("pięć koron norweskich zero øre", NumberToText.Convert(5.00M, CreateNumberToTextOption("NOK")));
      //  }
      // [Fact]
      //  public void Test_CurrencySEK_1()
      //  {
      //      Assert.Equal("jedna korona szwedzka", NumberToText.Convert(1, CreateNumberToTextOption( "SEK")));
      //  }
      // [Fact]
      //  public void Test_CurrencySEK_2()
      //  {
      //      Assert.Equal("dwie korony szwedzkie", NumberToText.Convert(2, Currency.SEK));
      //  }
      // [Fact]
      //  public void Test_CurrencySEK_5()
      //  {
      //      Assert.Equal("pięć koron szwedzkich zero øre", NumberToText.Convert(5.00M, CreateNumberToTextOption("SEK")));
      //  }
      // [Fact]
      //  public void Test_CurrencySEK_5NOSTEM()
      //  {
      //      Assert.Equal("piec koron szwedzkich zero øre", NumberToText.Convert(5.00M, Currency.SEK));
      //  }
    }
}
