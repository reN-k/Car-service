using SL_Cars_v2.Menues;
using SL_Cars_v2.Services;
using System;
using System.Collections.Generic;


namespace SL_Cars_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Car > carPark = new List<Car>();
            Supercar supercar= new Supercar();
            Truck truck = new Truck();
            Bus bus = new Bus();

            Console.WriteLine("Welcome, friend");

            Menu menu = new Menu(carPark,TypeService.GetCarTypesList());
            MainMenu mainMenu = new MainMenu();



        }
    }
}
