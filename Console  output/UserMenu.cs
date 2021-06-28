using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    
    class UserMenu
    {
        public static List<Car> carPark;
        public List<string> options = new List<string>();

        
        
        public UserMenu(List<Car> cars)
        {
            carPark = cars;
        }

        
        public void FirstPage()
        {
            options.Clear();

            Console.WriteLine("Choose what you want to do:\n" +
                "1 - Add car, 2 - Take the car from the garage , 0 - Exit.");
            options.Add("1");
            options.Add("2");
            options.Add("0");

            string userChoise = KeywordHandler.OneElementHandler(options);
            

            switch (userChoise)
            {
                case "0": 
                    Console.WriteLine("See you next time <3");
                    break;
                case "1":
                    CarAdd();
                    break;
                case "2":
                    CarFromGarage();
                    break;
            }
            
        }

        public void CarAdd()
        {
            options.Clear();
            Console.WriteLine("Which car should we add?");
            

            for (int i = 1; i <= (int)CarsTypes.Bus; i++)
            {
                Console.Write($"{i} - {(CarsTypes)i}; ");
                options.Add(Convert.ToString(i));
            }
            Console.WriteLine("0 - Back.");
            options.Add("0");

            string userChoise = KeywordHandler.OneElementHandler(options);
            switch (Convert.ToInt32(userChoise))
            {
                case (int)CarsTypes.Supercar:
                    {
                        carPark.Add(new Supercar());
                        FirstPage();
                        break;
                    }
                case (int)CarsTypes.Truck:
                    {
                        carPark.Add(new Truck());
                        FirstPage();
                        break;
                    }
                case (int)CarsTypes.Bus:
                    {
                        carPark.Add(new Bus());
                        FirstPage();
                        break;
                    }
                case 0:
                    {
                        FirstPage();
                        break;
                    }
            }

        }

        public void CarChosen(Car chosenCar)
        {
            options.Clear();

            Console.WriteLine($"Nice choise, we got {chosenCar.Name}, what shell we do?:\n" +
                $"1 - Test drive, 2 - Check state, 3 - Fix problems, 0 - Put car back.");
            options.Add("1"); 
            options.Add("2");
            options.Add("3"); 
            options.Add("0");

            string userChoise = KeywordHandler.OneElementHandler(options);
            
            switch (userChoise)
            {
                case "1":
                    chosenCar.Move();
                    CarChosen(chosenCar);
                    break;
                case "2":
                    chosenCar.Checkup();
                    CarChosen(chosenCar);
                    break;
                case "3":
                    chosenCar.Repair();
                    CarChosen(chosenCar);
                    break;
                case "0":
                    FirstPage();
                    break;
            }

        } 

        public void CarFromGarage()
        {
            options.Clear();

            if (carPark.Count == 0)
            { 
                Console.WriteLine("No cars at garage :c");
                FirstPage();
            }
            else
            {
                Console.WriteLine($"We got {carPark.Count} cars at garage. Pick one of them:");

                for (int i = 0; i < carPark.Count; i++)
                {
                    options.Add(Convert.ToString(i + 1));
                    Console.Write($"{i + 1} - {carPark[i].Name}, ");
                }
                Console.WriteLine("0 - Back.");
                options.Add("0");
                string userChoise = KeywordHandler.OneElementHandler(options);

                if (userChoise == "0") FirstPage();
                else CarChosen(carPark[Convert.ToInt32(userChoise) - 1]);
            }
        }
    }
}
