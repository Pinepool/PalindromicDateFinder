using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromic
{
    public static class Printer
    {
        private const string dateFormat = "dd/MM/yyyy";

        // Prints a date to console
        public static void PrintDate(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString(dateFormat));
        }

        // Changes the colour of the console text & background
        private static void SetPrintColour(ConsoleColor consoleColourText, ConsoleColor consoleColourBackground = ConsoleColor.Black)
        {
            Console.ForegroundColor = consoleColourText;
            Console.BackgroundColor = consoleColourBackground;
        }

        // Sets the colour for printing a date with no significance
        public static void SetPrintColourNormal()
        {
            SetPrintColour(ConsoleColor.Gray, ConsoleColor.Black);
        }

        public static void SetPrintColourNormalAlternative()
        {
            SetPrintColour(ConsoleColor.DarkGray, ConsoleColor.Black);
        }

        // Sets the colour for printing a date with significance: i.e. a palindromic date
        public static void SetPrintColourSpecial()
        {
            SetPrintColour(ConsoleColor.White, ConsoleColor.Red);
        }
    }
}
