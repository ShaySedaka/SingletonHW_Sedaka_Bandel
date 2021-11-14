using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSingleton_Shay_Ron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== A NEW DAY IN THE BORING OFFICE ===\n\n");
            Console.WriteLine("- There is one very old industrial printer in the office, connected to the network.\n-------------------------------------------------\n");

            Console.WriteLine("Bob opens up his WORD client and enqueues 2 jobs for the printer...\n\n");

            PrinterSingleton bobsWordClient = PrinterSingleton.GetSingleton();

            bobsWordClient.AddPrinterJob("Hello, I am the first job from Bob's computer.");
            bobsWordClient.AddPrinterJob("Hello, I am the second job from Bob's computer.");


            Console.WriteLine("Mike opens up his WORD client and enqueues 1 job for the printer...\n\n");

            PrinterSingleton mikesWordClient = PrinterSingleton.GetSingleton();

            mikesWordClient.AddPrinterJob("Hello, I am the first job from Mike's computer.");


            Console.WriteLine("- Mike presses the PRINT button 3 times and this comes out...\n\n");

            mikesWordClient.PrintFromJobQueue();
            mikesWordClient.PrintFromJobQueue();
            mikesWordClient.PrintFromJobQueue();

            Console.ReadKey();

        }
    }
}
