using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SL_Cars_v2
{
    static class KeywordHandler
    {
        public static string OneElementHandler(List<string> validValues)
        {
            string inputData = Console.ReadLine();

            if (validValues.Contains(inputData))
            {
                return inputData;
            }
            else
            {
                ErrorDisplay.ShowError("Wrong value. Repeat: ");
                return OneElementHandler(validValues);
            }
        }

        public static List<string> SomeElementsHandler(List<string> validValues)
        {
            string inputData = Console.ReadLine();
            var inputValues = inputData.Split(',');

            //List<string> inputValues = inputData.Split(',').ToList();

            foreach (var inputValue in inputValues)
            {
                inputValue.Trim();

                if (!validValues.Contains(inputValue))
                {
                    ErrorDisplay.ShowError($"Wrong value \"{inputValue}\". Repeat:");
                    return SomeElementsHandler(validValues);
                }
            }
            
            return inputValues.ToList();

        }


    }
}
