using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSingleton_Shay_Ron
{
    public sealed class PrinterSingleton
    {
        private static PrinterSingleton _instance;
        private static object _lockThis = new object();

        public Queue<string> _printerJobs;

        private PrinterSingleton() {
            _printerJobs = new Queue<string>();
        }

        public static PrinterSingleton GetSingleton()
        {
            lock (_lockThis)
            {
                if (_instance == null) _instance = new PrinterSingleton();
            }
            return _instance;
        }

        public  void AddPrinterJob(string job)
        {
            GetSingleton()._printerJobs.Enqueue(job);
        }
        public  string PrintFromJobQueue()
        {
            if (GetSingleton()._printerJobs.Count > 0)
            { 
                string job = GetSingleton()._printerJobs.Dequeue();
                Console.WriteLine(job);

                return job;
            }

            return "This printer has an empty job queue.";

        }
    }
}
