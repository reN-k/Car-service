using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    class Truck : Car
    {
        public Truck()
        {
            this.Name = "Truck";
            this.details.Add(new Detail("Trailer",3));
        }
    }
}
