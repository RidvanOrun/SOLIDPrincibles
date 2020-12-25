using SOLİDPrincibles.Lab5_DIP.GodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab5_DIP.GodExample.Concrete
{
    public class FastFood
    {
        List<IProduct> products;

        public FastFood()
        {
            products = new List<IProduct>();
        }
        public string GenerateInstruction()
        {
            string instruction = string.Empty;

            foreach (var item in products)
            {
                instruction += ""; item.GetCooking();
            }
            return instruction;

        }
    }
}
