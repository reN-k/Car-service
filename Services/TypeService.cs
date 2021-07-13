using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2.Services
{
    static class TypeService
    {
        public static List<Type> GetCarTypesList()
        {
            List<Type> carTypesList = new List<Type>();

            carTypesList.Add(typeof(Supercar));
            carTypesList.Add(typeof(Truck));
            carTypesList.Add(typeof(Bus));

            return carTypesList;
        }
    }
}
