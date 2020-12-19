using SOLİDPrincibles.Lab2_OCP.GodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab2_OCP.GodExample.Concrete
{
    public class BlackTea:GoodTeaShop
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 5.00;
        }
    }
}
