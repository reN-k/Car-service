using SL_Cars_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Menues
{
    class Menu : IMenuable
    {
        public ActionDictionaryModel ActionDictionary { get; } = new ActionDictionaryModel();
        public static List<Car> carPark;
        public static List<Type> carTypes;


        public string MenuName { get; } = "Menu";
        virtual public string ChooseString { get; } = "Choose what you want to do:";

        protected bool exitPressed = false;

        public Menu() { }
        public Menu(List<Car> carPark, List<Type> carTypes)
        {
            Menu.carPark = carPark;
            Menu.carTypes = carTypes;
        }

        public void DisplayMenu(string menuName)
        {
            
                        
            while (!exitPressed)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(menuName);
                Console.ResetColor();

                Console.WriteLine(ChooseString);

                ActionDictionary.DisplayAllActionsInfo();
                ActionDictionary.MakeAction();
            }
        }
        protected void BackToPreviosMenu()
        {
            this.exitPressed = true;
        }

    }
}
