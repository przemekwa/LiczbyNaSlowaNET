using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyNaSlowaNET_Testy
{
    public static class ExtensionMethod
    {
        public static IEnumerable<IEnumerable<T>> SplitInToParts<T>(this IList<T> source, short parts)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Count == 0)
            {
                throw new InvalidOperationException("Source cannot be empty");
            }

            if (parts == 0)
            {
                throw new ArgumentException("Cannot divide by zero.", "parts");
            }

            var totalRows = source.Count;

            var skipRows = 0;

            var takeRows = totalRows / parts;

            for (var part = 0; part < parts; part++)
            {
                var partialList = new List<T>();

                partialList.AddRange(source.Skip(skipRows).Take(takeRows));

                skipRows += takeRows;

                if (part == parts - 2)
                {
                    takeRows = totalRows - skipRows;
                }

                yield return partialList;
            }

        }
    }
}
