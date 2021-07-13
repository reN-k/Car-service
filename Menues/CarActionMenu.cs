using SL_Cars_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Menues
{
    class CarActionMenu : Menu, IMenuable
    {

        new public string MenuName { get; } = "Car actions menu";
        public Car chosenCar;
        override public string ChooseString { get; } = "Make action with car: ";

        public CarActionMenu(Car car)
        {
            chosenCar = car;
            ChooseString = $"You sit in {chosenCar.Name}, what are we going to do:";

            ActionDictionary.SetActions(
                new ActionModel(() => BackToPreviosMenu(), "Back"),
                new ActionModel(() => chosenCar.Move(), "Drive on car"),
                new ActionModel(() => chosenCar.Checkup(), "Check car"),
                new ActionModel(() => chosenCar.Repair(), "Repair car"));

            DisplayMenu(MenuName);
        }
    }
}
