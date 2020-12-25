using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab5_DIP.BadExample
{
     public class ChickenMeatHouse
    {
        BadMeat badMeat = new BadMeat();
        BadChicken badChicken = new BadChicken();

        public string GetFood()
        {
            return badMeat.GetMeat() + "" + badChicken.GetChicken();

        }
    }
}
