using SOLİDPrincibles.Lab5_DIP.GodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab5_DIP.GodExample.Concrete
{
    public class KirmiziEt : IProduct
    {
        public string GetCooking()
        {
            return "Kırmızı et tarifi";
        }
    }
}
