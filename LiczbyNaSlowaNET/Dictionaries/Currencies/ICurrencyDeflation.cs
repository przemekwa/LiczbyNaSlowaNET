namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    /// <summary>
    ///     Interface for classes that define deflation table for specific currency.
    /// </summary>
    public interface ICurrencyDeflation
    {
        /// <summary>
        ///     Current currency code as stands in ISO 4217
        /// </summary>
        string CurrencyCode { get; }

        /// <summary>
        ///     Deflation table used during conversion.
        /// </summary>
        string[,] GetDeflationTable { get; } 
        bool HasStems { get; set; }

    }
}