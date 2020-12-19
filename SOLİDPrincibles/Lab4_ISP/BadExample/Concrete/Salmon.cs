using SOLİDPrincibles.LAb4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.LAb4_ISP.BadExample.Concrete
{
    public class Salmon : IFish //Salmon.cs sınıfımız IFish.cs sınıfından kalıtım aldığında, gereksiz "Predatory()" yeteneğinide kazanarak bu ilkeye ters düşülmüştür.
    {
        public string Gill()
        {
            return "All Salmon have a Gill for breathing";
        }

        public string Predatory()
        {
            return "Salmon can't predatory";
        }

        public string Swim()
        {
            return "Salmons swim...";
        }
    }
}
