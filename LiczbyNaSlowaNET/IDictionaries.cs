using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiczbyNaSlowaNET
{
    internal interface IDictionaries
    {
        List<String> Unity { get; }
        List<String> OthersTens { get; }
        List<String> Tens{ get; }
        List<String> Hundreds{ get; }
        string[,] Endings{ get; }
        List<String> Sign{ get; }
        string[,] Current{ get; }
    }
}
