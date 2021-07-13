using SL_Cars_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Menues
{
    class CarAddMenu : Menu
    {
        new public string MenuName { get; } = "Car add menu";

        override public string ChooseString { get; } = "Which car shoud we add:";

        public CarAddMenu()
        {
            
            // сделать для типов машин!!!
            //foreach (var car in CarsTypes)

            ActionDictionary.SetActions(
                new ActionModel(() => BackToPreviosMenu(), "Back"),
                new ActionModel(() => carPark.Add(new Supercar()), "Supercar"),
                new ActionModel(() => carPark.Add(new Truck()), "Truck"),
                new ActionModel(() => carPark.Add(new Bus()), "Bus"));

            DisplayMenu(MenuName);

        }
    }
}
