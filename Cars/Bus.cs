using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    class Bus : Car
    {
        public Bus()
        {
            this.Name = "Truck";
            this.details.Add(new Detail("Salon",4));
        }
    }
}
