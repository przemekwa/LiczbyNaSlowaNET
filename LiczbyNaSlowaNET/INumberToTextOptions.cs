using LiczbyNaSlowaNET.Currencies;

namespace LiczbyNaSlowaNET
{
    public interface INumberToTextOptions
    {
        ICurrencyDeflation Currency { get; set; }
        string SplitDecimal { get; set; }
        bool WithStems { get;   }
    }
}