using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    class Supercar : Car
    {
        public Supercar()
        {
            this.Name = "Supercar";
            this.details.Add(new Detail("Turbocharger",2));
        }


    }
}
