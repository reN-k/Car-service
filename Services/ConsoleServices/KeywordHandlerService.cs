using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SL_Cars_v2
{
    static class KeywordHandlerService
    {
        public static string OneElementHandler(List<string> validValues)
        {
            Console.Write("Write your choice: ");
            string inputData = Console.ReadLine();

            if (validValues.Contains(inputData))
            {
                Console.WriteLine();
                return inputData;
            }
            else
            {
                Console.WriteLine();
                ErrorDisplayService.ShowError("Wrong value. Repeat: ");
                Console.WriteLine();
                return OneElementHandler(validValues);
            }
        }

        public static List<string> SomeElementsHandler(List<string> validValues)
        {
            Console.Write("Write your choices: ");
            string inputData = Console.ReadLine();
            var inputValues = inputData.Split(',');

            foreach (var inputValue in inputValues)
            {
                inputValue.Trim();

                if (!validValues.Contains(inputValue))
                {
                    ErrorDisplayService.ShowError($"Wrong value \"{inputValue}\". Repeat:");
                    Console.WriteLine();
                    return SomeElementsHandler(validValues);
                }
            }
            Console.WriteLine();
            return inputValues.ToList();
        }
    }
}
