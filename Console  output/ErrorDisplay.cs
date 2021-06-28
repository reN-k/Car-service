using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    static public class ErrorDisplay
    {
        static public void ShowError(string errorText)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine(errorText);
            Console.ResetColor();
        }

    }
}
