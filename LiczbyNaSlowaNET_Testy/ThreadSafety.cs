using LiczbyNaSlowaNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LiczbyNaSlowaNET_Testy
{
    [TestClass]
    public class ThreadSafety
    {
      List<string> testResult = new List<string>();

       [TestMethod]
        public void ThreadSafetyTest()
        {
           var taskList = new List<Task>();

           var objectsToConvert = new List<int>();

            objectsToConvert.AddRange(Enumerable.Range(1, 5000));

            foreach (var list in objectsToConvert.SplitInToParts(4))
            {
                taskList.Add(new Task(this.ConvewrtTask, list));
            }

            taskList.ForEach(t => t.Start());


            foreach (var t in taskList)
            {
                t.Wait();
            }

            using (var sr = new StreamWriter(@"d:\plik2.txt"))
            {
                testResult.ForEach(tr => sr.WriteLine(tr));
            }

          foreach( var s in testResult.Where(s=>s != null))
          {
              Assert.AreNotEqual(true, s.Length > 60, s);
          }

         



        }


        private void ConvewrtTask(object obj)
        {
            var list = obj as IEnumerable<int>;
            
            foreach (var i in list)
            {
               testResult.Add(NumberToTextConverter.Convert(i, NumberToTextConverter.Currency.PL));
            }
        }
    }
}
