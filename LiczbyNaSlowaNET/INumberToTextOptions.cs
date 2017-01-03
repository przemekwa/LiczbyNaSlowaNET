
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNET
{
    using Dictionaries.Currencies;

    public interface INumberToTextOptions
    {
        Currency Currency { get; set; }
        Dictionaries.ICurrencyDictionary Dictionary { get; set; }
        string SplitDecimal { get; set; }
        bool Stems { get; set; }
    }
}