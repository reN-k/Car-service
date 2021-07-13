using System;
using System.Collections.Generic;
using System.Text;

namespace SL_Cars_v2
{
    class Detail
    {
        public int Heals { get; set; } = 100;
        public string DetailName { get; set; }
        private int repairMultiplier = 1;


        public Detail() { }

        public Detail(string name, int multiplier = 1)
        {
            if (Enum.IsDefined(typeof(DetailsTypes), name))
            {
                this.repairMultiplier = multiplier;
                this.DetailName = name;
            } 
            else
            {
                ErrorDisplayService.ShowError($"You can't add detail {name} to car");
                // что-то с ним сделать

            }
        }

        public void TakeDamage()
        {
            Random random = new Random();

            this.Heals -= random.Next(0, 40);
            if (this.Heals < 0) this.Heals = 0;
        }
        public void TakeRepair() 
        {
            this.Heals = 100;
        }

        public int RepairPrice()
        {
            int repairPrice = (100 - this.Heals) * repairMultiplier;

            return repairPrice;
        }
    }
}
