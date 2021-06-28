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

            UserMenu firstPage = new UserMenu(carPark);

            Console.WriteLine("Welcome, friend");
            firstPage.FirstPage();

        }
    }
}
