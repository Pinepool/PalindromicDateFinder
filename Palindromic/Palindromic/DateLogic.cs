using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromic
{
    public static class DateLogic
    {
        private static DateTime start = new DateTime(0);
        private static DateTime stop = new DateTime(0);

        private static List<DateTime> palindromes = new List<DateTime>();

        public static void Traverse()
        {
            bool alternate = true;
            while (start < stop)
            {
                if (alternate)
                {
                    Printer.SetPrintColourNormal();
                }
                else
                {
                    Printer.SetPrintColourNormalAlternative();
                }

                alternate = !alternate;

                Printer.PrintDate(start);
                start = start.AddDays(1);
            }
        }

        public static void SetStartDate(DateTime newStartDate)
        {
            start = new DateTime(newStartDate.Year, newStartDate.Month, newStartDate.Day);
        }

        public static void SetStartDate()
        {
            start = new DateTime(0);
            SetStartDate(start);
        }

        public static void SetStopDate(DateTime newStopDate)
        {
            stop = new DateTime(newStopDate.Year, newStopDate.Month, newStopDate.Day);
        }
    }
}
