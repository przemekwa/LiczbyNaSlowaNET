using LiczbyNaSlowaNET;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;


namespace LiczbyNaSlowaNET_Testy
{
    
    public class ThreadSafety
    {
        List<string> testResult = new List<string>();

        [Fact(Skip = "Refaktoryzacja potrzebna. Test nie do końca skuteczny")]
        // TODO: Test na ThreadSafetyTest jest nie do końca dobry. Potrzeba refaktoryzacja.
        public void ThreadSafetyTest()
        {
           var taskList = new List<Task>();

           var objectsToConvert = new List<int>();

            objectsToConvert.AddRange(Enumerable.Range(1, 5000));

            foreach (var list in objectsToConvert.SplitInToParts(5))
            {
                taskList.Add(new Task(this.ConvewrtTask, list));
            }

            taskList.ForEach(t => t.Start());

            foreach (var t in taskList)
            {
                t.Wait();
            }

            using (var sr = new StreamWriter(@"j:\LiczbyNaSlowaTesty.txt"))
            {
                testResult.ForEach(tr => sr.WriteLine(tr));
            }

          foreach( var s in testResult.Where(s=>s != null))
          {
              Assert.NotEqual(true, s.Length > 99);
          }
        }


        private void ConvewrtTask(object obj)
        {
            var list = obj as IEnumerable<int>;
            
            foreach (var beforeComma in list)
            {
                foreach (var afterComma in Enumerable.Range(0, 30))
                {
                    var decimalNumber = decimal.Parse(beforeComma + "," + afterComma);

                    testResult.Add(string.Format("{0} -> {1}", decimalNumber, NumberToText.Convert(decimalNumber, Currency.PLN)));
                }
            }
        }
    }
}
