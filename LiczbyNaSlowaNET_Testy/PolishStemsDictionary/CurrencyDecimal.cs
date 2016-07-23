
// Copyright (c) 2014 Przemek Walkowski

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiczbyNaSlowaNET;
using System.Globalization;
using Ninject;
using LiczbyNaSlowaNET.Currencies;
using Ninject.Extensions.Conventions;

namespace LiczbyNaSlowaNET_Testy.PolishStemsDictionary
{ 

    
    [TestClass]
    public class CurrencyDecimal :TestBase
    {

        private static IKernel kernel;
        public CurrencyDecimal()
        {
            kernel = new StandardKernel();

            kernel.Bind(typeof(IDictionaries)).To<PolishWithsStemsDictionary>();

            kernel.Bind<ICurrencyDeflationFactory>().To<CurrencyDeflationFactory>().WithConstructorArgument("withStems", kernel.Get<IDictionaries>().HasStems);
            kernel.Bind(x => x.FromAssemblyContaining<ICurrencyDeflation>().SelectAllClasses().InheritedFrom<ICurrencyDeflation>().BindAllInterfaces());
        }
        [TestMethod]
        public void Test_Currency_6_416()
        {
            Assert.AreEqual("sześć złotych czterdzieści dwa grosze", NumberToText.Convert(6.416M, CreateNumberToTextOption("PLN")));
        }

        private static NumberToTextOptions CreateNumberToTextOption(string currencyCode)
        {
            return new NumberToTextOptions() { Currency = kernel.Get<ICurrencyDeflationFactory>().CreateInstance(currencyCode), Dictionary = kernel.Get<IDictionaries>() };
        }

        [TestMethod]
        public void Test_Currency_6_414()
        {
            Assert.AreEqual("sześć złotych czterdzieści jeden groszy", NumberToText.Convert(6.414M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_6_400()
        {
            Assert.AreEqual("sześć złotych czterysta groszy", NumberToText.Convert(6.400M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_4_4()
        {
            Assert.AreEqual("cztery złote czterdzieści groszy", NumberToText.Convert(4.4M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_4_40()
        {
            Assert.AreEqual("cztery złote czterdzieści groszy", NumberToText.Convert(4.40M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_12_23()
        {
            Assert.AreEqual("dwanaście złotych dwadzieścia trzy grosze", NumberToText.Convert(12.23M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_12_02()
        {
            Assert.AreEqual("dwanaście złotych dwa grosze", NumberToText.Convert(12.02M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_0_12()
        {
            Assert.AreEqual("zero złotych dwanaście groszy", NumberToText.Convert(0.12M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_123_12()
        {
            Assert.AreEqual("sto dwadzieścia trzy złote dwanaście groszy", NumberToText.Convert(123.12M, CreateNumberToTextOption("PLN")));
        }


        [TestMethod]
        public void Test_Currency_125_12()
        {
            Assert.AreEqual("sto dwadzieścia pięć złotych dwanaście groszy", NumberToText.Convert(125.12M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_126_12()
        {
            Assert.AreEqual("sto dwadzieścia sześć złotych dwanaście groszy", NumberToText.Convert(126.12M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_23_12()
        {
            Assert.AreEqual("dwadzieścia trzy złote dwanaście groszy", NumberToText.Convert(23.12M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_Infinity()
        {
            Assert.AreEqual("", NumberToText.Convert(999999999999999999999M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_13_0()
        {
            Assert.AreEqual("trzynaście złotych zero groszy", NumberToText.Convert(13.0M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_2594()
        {
            Assert.AreEqual("dwa tysiące pięćset dziewięćdziesiąt cztery złote", NumberToText.Convert(2594, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_4()
        {
            Assert.AreEqual("cztery złote", NumberToText.Convert(4, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_2()
        {
            Assert.AreEqual("dwa złote", NumberToText.Convert(2, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_2_68()
        {
            Assert.AreEqual("dwa złote sześćdziesiąt osiem groszy", NumberToText.Convert(2.68M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_1()
        {
            Assert.AreEqual("jeden złoty", NumberToText.Convert(1, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_1_02()
        {
            Assert.AreEqual("jeden złoty dwa grosze", NumberToText.Convert(1.02M, CreateNumberToTextOption("PLN")));
        }


       [TestMethod]
        public void Test_Currency_1_22()
        {
            Assert.AreEqual("jeden złoty dwadzieścia dwa grosze", NumberToText.Convert(1.22M, CreateNumberToTextOption("PLN")));
        }
        
        [TestMethod]
        public void Test_Currency_0_01()
        {
            Assert.AreEqual("zero złotych jeden grosz", NumberToText.Convert(0.01M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_0_20()
        {
            Assert.AreEqual("zero złotych dwadzieścia groszy", NumberToText.Convert(0.20M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_5()
        {
            Assert.AreEqual("pięć złotych", NumberToText.Convert(5, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_3_99()
        {
            Assert.AreEqual("trzy złote dziewięćdziesiąt dziewięć groszy", NumberToText.Convert(3.99M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_999_00()
        {
            Assert.AreEqual("dziewięćset dziewięćdziesiąt dziewięć złotych zero groszy", NumberToText.Convert(999.00M, CreateNumberToTextOption("PLN")));
        }


        [TestMethod]
        public void Test_Currency_1000_00()
        {
            Assert.AreEqual("jeden tysiąc złotych zero groszy", NumberToText.Convert(1000.00M, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_2320_00()
        {
            Assert.AreEqual("dwa tysiące trzysta dwadzieścia złotych zero groszy", NumberToText.Convert(2320.00M, CreateNumberToTextOption("PLN")));
        }
        
        [TestMethod]
        public void Test_Currency_2596()
        {
            Assert.AreEqual("dwa tysiące pięćset dziewięćdziesiąt sześć złotych", NumberToText.Convert(2596, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_Currency_20367_40()
        {
            Assert.AreEqual("dwadzieścia tysięcy trzysta sześćdziesiąt siedem złotych czterdzieści groszy", NumberToText.Convert(20367.40M, CreateNumberToTextOption("PLN")));
        }
        [TestMethod]
        public void Test_CurrencyEur_100_34()
        {
            Assert.AreEqual("sto euro trzydzieści cztery centy", NumberToText.Convert(100.34M, CreateNumberToTextOption("EUR")));
        }
        [TestMethod]
        public void Test_CurrencyChf_100()
        {
            Assert.AreEqual("sto franków szwajcarskich", NumberToText.Convert(100, CreateNumberToTextOption("CHF")));
        }

        [TestMethod]
        public void Test_CurrencyPln_535535_53()
        {
            Assert.AreEqual("pięćset trzydzieści pięć tysięcy pięćset trzydzieści pięć złotych pięćdziesiąt trzy grosze", NumberToText.Convert(535535.53M, CreateNumberToTextOption("PLN")));
        }
      
             [TestMethod]
        public void Test_CurrencyPln_535535_53_fromString()
        {
            var valueToConvert = "535535.53"; 
            //var monasConvertedValue = decimal.Parse(valueToConvert.Replace(",", "."));
            var numbertoConvert = decimal.Parse(valueToConvert.Replace(",","."), NumberFormatInfo.InvariantInfo);
            Assert.AreEqual("pięćset trzydzieści pięć tysięcy pięćset trzydzieści pięć złotych pięćdziesiąt trzy grosze", NumberToText.Convert(numbertoConvert, CreateNumberToTextOption("PLN")));
        }

        [TestMethod]
        public void Test_CurrencyPln_606015()
        {
            var valueToConvert = "606015.00";
            var numbertoConvert = decimal.Parse(valueToConvert.Replace(",", "."), NumberFormatInfo.InvariantInfo);
            Assert.AreEqual("sześćset sześć tysięcy piętnaście złotych zero groszy", NumberToText.Convert(numbertoConvert, CreateNumberToTextOption("PLN")));
        }
        [TestMethod]
        public void Test_CurrencyPln_9696_24()
        {
            var valueToConvert = "9696,24";
            var numbertoConvert = decimal.Parse(valueToConvert.Replace(",", "."), NumberFormatInfo.InvariantInfo);
            Assert.AreEqual("dziewięć tysięcy sześćset dziewięćdziesiąt sześć złotych dwadzieścia cztery grosze", NumberToText.Convert(numbertoConvert, CreateNumberToTextOption("PLN")));
        }
        [TestMethod]
        public void Test_CurrencyCZK_1()
        {
            Assert.AreEqual("jedna korona czeska", NumberToText.Convert(1, CreateNumberToTextOption("CZK")));
        }
        [TestMethod]
        public void Test_CurrencyCZK_2()
        {
            Assert.AreEqual("dwie korony czeskie", NumberToText.Convert(2, CreateNumberToTextOption("CZK")));
        }
        [TestMethod]
        public void Test_CurrencyCZK_5()
        {
            Assert.AreEqual("pięć koron czeskich zero halerzy", NumberToText.Convert(5.00M, CreateNumberToTextOption("CZK")));
        }
        [TestMethod]
        public void Test_CurrencyGBP_1()
        {
            Assert.AreEqual("jeden funt brytyjski", NumberToText.Convert(1, CreateNumberToTextOption( "GBP")));
        }
        [TestMethod]
        public void Test_CurrencyGBP_2()
        {
            Assert.AreEqual("dwa funty brytyjskie", NumberToText.Convert(2, CreateNumberToTextOption("GBP")));
        }
        [TestMethod]
        public void Test_CurrencyGBP_5()
        {
            Assert.AreEqual("pięć funtów brytyjskich zero pensów", NumberToText.Convert(5.00M, CreateNumberToTextOption("GBP")));
        }
        [TestMethod]
        public void Test_CurrencyHUF_1()
        {
            Assert.AreEqual("jeden forint", NumberToText.Convert(1, "HUF"));
        }
        [TestMethod]
        public void Test_CurrencyHUF_2()
        {
            Assert.AreEqual("dwa forinty", NumberToText.Convert(2, "HUF"));
        }
        [TestMethod]
        public void Test_CurrencyHUF_5()
        {
            Assert.AreEqual("pięć forintów zero", NumberToText.Convert(5.00M, CreateNumberToTextOption("HUF")));
        }
        [TestMethod]
        public void Test_CurrencyJPY_1()
        {
            Assert.AreEqual("jeden jen", NumberToText.Convert(1, CreateNumberToTextOption("JPY")));
        }
        [TestMethod]
        public void Test_CurrencyJPY_2()
        {
            Assert.AreEqual("dwa jeny", NumberToText.Convert(2, CreateNumberToTextOption("JPY")));
        }
        [TestMethod]
        public void Test_CurrencyJPY_5()
        {
            Assert.AreEqual("pięć jenów zero", NumberToText.Convert(5.00M, CreateNumberToTextOption("JPY")));
        }
        [TestMethod]
        public void Test_CurrencyLTL_1()
        {
            Assert.AreEqual("jeden lit litewski", NumberToText.Convert(1, CreateNumberToTextOption( "LTL")));
        }
        [TestMethod]
        public void Test_CurrencyLTL_2()
        {
            Assert.AreEqual("dwa lity litewskie", NumberToText.Convert(2, CreateNumberToTextOption("LTL")));
        }
        [TestMethod]
        public void Test_CurrencyLTL_5()
        {
            Assert.AreEqual("pięć litów litewskich zero centów", NumberToText.Convert(5.00M, CreateNumberToTextOption( "LTL")));
        }
        [TestMethod]
        public void Test_CurrencyNOK_1()
        {
            Assert.AreEqual("jedna korona norweska", NumberToText.Convert(1, CreateNumberToTextOption("NOK")));
        }
        [TestMethod]
        public void Test_CurrencyNOK_2()
        {
            Assert.AreEqual("dwie korony norweskie", NumberToText.Convert(2, CreateNumberToTextOption("NOK")));
        }
        [TestMethod]
        public void Test_CurrencyNOK_5()
        {
            Assert.AreEqual("pięć koron norweskich zero øre", NumberToText.Convert(5.00M, CreateNumberToTextOption("NOK")));
        }
        [TestMethod]
        public void Test_CurrencySEK_1()
        {
            Assert.AreEqual("jedna korona szwedzka", NumberToText.Convert(1, CreateNumberToTextOption( "SEK")));
        }
        [TestMethod]
        public void Test_CurrencySEK_2()
        {
            Assert.AreEqual("dwie korony szwedzkie", NumberToText.Convert(2, "SEK"));
        }
        [TestMethod]
        public void Test_CurrencySEK_5()
        {
            Assert.AreEqual("pięć koron szwedzkich zero øre", NumberToText.Convert(5.00M, CreateNumberToTextOption("SEK")));
        }
        [TestMethod]
        public void Test_CurrencySEK_5NOSTEM()
        {
            Assert.AreEqual("piec koron szwedzkich zero øre", NumberToText.Convert(5.00M,  "SEK" ));
        }
    }
}
