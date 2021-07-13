using SL_Cars_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Menues
{
    class CarSelectionMenu : Menu
    {
        new public string MenuName { get; } = "Car selection menu";

        override public string ChooseString { get; } = $"We got {carPark.Count} cars at garage. Pick one of them:";

        public CarSelectionMenu()
        {
            if (carPark.Count == 0)
            {
                Console.WriteLine("Sorry, garage empty");
                Console.WriteLine();
                BackToPreviosMenu();
            }
            else
            {
                
                ActionDictionary.AddExtraActions(new ActionModel(() => BackToPreviosMenu(), "Back", "0"));

                int counter = 1;

                foreach (Car car in carPark)
                {
                    ActionDictionary.AddExtraActions(new ActionModel(() => new CarActionMenu(car), $"{car.Name}", counter.ToString()));
                    counter++;
                }

                DisplayMenu(MenuName);
            }
        }
    }
}
