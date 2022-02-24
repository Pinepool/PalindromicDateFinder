using System;

namespace Palindromic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime testDateTime = new DateTime(2000, 12, 24);
            Printer.PrintDate(testDateTime);

            for (int i = 0; i < 10; i++)
            {
                testDateTime = testDateTime.AddDays(1d);

                if ((i % 2) == 0)
                {
                    Printer.SetPrintColourNormal();
                }
                else
                {
                    Printer.SetPrintColourNormalAlternative();
                }

                Printer.PrintDate(testDateTime);
            }

            Console.ReadLine();
        }
    }
}
