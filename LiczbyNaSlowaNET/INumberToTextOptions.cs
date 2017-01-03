
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using Dictionaries.Currencies;

    public interface INumberToTextOptions
    {
        ICurrencyDeflation Currency { get; set; }
        Currency CurrencyDeflation { get; set; }
        string SplitDecimal { get; set; }

        bool Stems { get; set; }
    }
}