namespace LiczbyNaSlowaNET.Dictionaries.Currencies
{
    public enum DeflationPhraseType { BeforeComma = 1, AfterComma };

    /// <summary>
    ///     Interface for classes that define deflation table for specific currency.
    /// </summary>
    public interface ICurrencyDeflation
    {
        /// <summary>
        ///     Current currency code as stands in ISO 4217
        /// </summary>
        Currency CurrencyCode { get; }

        // maybe change grammar form from int to some int (like DeflationPhraseType)?
        string GetDeflationPhrase( DeflationPhraseType phraseType, int grammarForm, bool withStems );

    }
}