using System.Collections.Generic;

namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    /// <summary>
    ///     Interface for classes that define factory able to create currency defaltion instances.
    /// </summary>
    public interface ICurrencyDeflationFactory
    {
        List<ICurrencyDeflation> CurrencyList { get; }
        List<string> AvailableCurrencyDeflations { get; }
        ICurrencyDeflation CreateInstance(string currencyCode); 
    }
}