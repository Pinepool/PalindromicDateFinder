using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromic
{
    public static class DateLogic
    {
        private static DateTime start = new DateTime(0);
        private static DateTime stop = new DateTime(0);

        private const string palindromeFormat = "ddMMyyyy";

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

                if (CheckPalindrome(start))
                {
                    Printer.SetPrintColourSpecial();
                    palindromes.Add(start);
                }

                Printer.PrintDate(start);

                start = start.AddDays(1);
            }
        }

        private static bool CheckPalindrome(DateTime dateTime)
        {
            bool result;

            string temp = dateTime.ToString(palindromeFormat);

            int i = 0;
            int j = temp.Length - 1;

            result = true;
            while (i < j)
            {
                if (temp[i] != temp[j])
                {
                    result = false;
                    break;
                }

                i++;
                j--;
            }

            return result;
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

        public static void ResetPalindromesList()
        {
            palindromes = new List<DateTime>();
        }

        public static void ListPalindromes()
        {
            Console.WriteLine("\n\n== Palindromic Dates ==");

            foreach (DateTime date in palindromes)
            {
                Printer.PrintDate(date);
            }


            Console.WriteLine("== End ==");
        }
    }
}
