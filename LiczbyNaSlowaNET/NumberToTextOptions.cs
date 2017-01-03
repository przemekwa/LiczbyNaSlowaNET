
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using Dictionaries;
    using Dictionaries.Currencies;

    public class NumberToTextOptions : INumberToTextOptions
    {
        public ICurrencyDeflation Currency { get; set; }

        public Currency CurrencyDeflation { get; set; }

        public IDictionaries Dictionary { get; set; }

        public string SplitDecimal { get; set; } = string.Empty;

        public bool Stems { get; set; }
    }
}