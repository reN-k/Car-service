using System;
using System.Collections.Generic;
using System.Text;
using SL_Cars_v2.Models;

namespace SL_Cars_v2.Menues
{
    class MainMenu : Menu
    {
        
        new public string MenuName { get; } = "Main menu";

        override public string ChooseString { get; } = "Choose what you want to do:";

        public MainMenu() 
        {
            ActionDictionary.SetActions(
                new ActionModel(() => { Console.WriteLine("See you next time <3"); this.exitPressed = true; }, "Exit from app", "Exit"),
                new ActionModel(() => CarAdd(), "Add car"),
                new ActionModel(() => CarSelection(), "Take car from the garage"));

            DisplayMenu(MenuName);
        }

        public void CarAdd()
        {
            CarAddMenu carAddMenu = new CarAddMenu();
        }
        
        public void CarSelection()
        {
            CarSelectionMenu carSelectionMenu = new CarSelectionMenu();

        }
    }
}
