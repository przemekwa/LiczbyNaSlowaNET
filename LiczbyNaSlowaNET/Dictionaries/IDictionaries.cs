using LiczbyNaSlowaNET.Currencies;
using System;
using System.Collections.Generic;

namespace LiczbyNaSlowaNET
{
    public interface IDictionaries
    {
        List<String> Unity { get; }
        List<String> OthersTens { get; }
        List<String> Tens{ get; }
        List<String> Hundreds{ get; }
        string[,] Endings{ get; }
        List<String> Sign{ get; }
        string[,] Current{ get; }
        List<ICurrencyDeflation> Currency { get; }
        bool HasStems { get; }
    }
}
