using SOLİDPrincibles.LAb4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.LAb4_ISP.BadExample.Concrete
{
    public class Piranha : IFish
    {
        public string Gill()
        {
            return "All Piranha have a gill for breathing";
        }

        public string Predatory()
        {
            return "Piranhas are Predatory";
        }

        public string Swim()
        {
            return "All Pirinha can swim...";
        }
    }
}
