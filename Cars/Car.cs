﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    abstract class Car : IMove, IService
    {
        public List<Detail> details = new List<Detail> { };
        public string Name { get; set; } = "Car";


        public Car()
        {
            this.details.Add(new Detail("Transmission"));
            this.details.Add(new Detail("Wheels"));
            this.details.Add(new Detail("Engine"));
        }

        public Car(int detailQuantity)
        {
            for (int i = 0; i < detailQuantity; i++)
            {
                details.Add(new Detail());
            }
        }

        // IService
        public void Repair() 
        {
            foreach (Detail detail in this.details)
            {
                detail.TakeRepair();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{this.Name} repaired");
            Console.ResetColor();
        }
        public void Checkup() 
        {
            int price = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{this.Name} state - ");
           
            foreach (var detail in details)
            {
                Console.Write($"{detail.DetailName} got {detail.Heals}/100, ");
                price += detail.RepairPrice();
            }
                       
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine($"Repair will cost {price}");
        }

        // IMove
        public void Move() 
        {
            bool canWeGo = true;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (Detail detail in this.details)
            {
                if (detail.Heals == 0) canWeGo = false;
            }

            if (canWeGo) 
            {
                Console.WriteLine($"Travel on {this.Name}");
                foreach (Detail detail in this.details)
                {
                    detail.TakeDamage();
                }
            } 
            else
            {
                Console.WriteLine($"Sry, sir, but {this.Name} is broken :C");
            }
            Console.ResetColor();
        }
    }

   
}
