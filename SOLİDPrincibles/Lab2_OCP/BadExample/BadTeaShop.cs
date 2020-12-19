using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab2_OCP.BadExample
{
    public class BadTeaShop
    {
        public enum TeaType
        {
            Black, Green
        }
        public double GetTotalPrice(double amount, TeaType teaType)
        {
            double totalPrice = 0;

            if (teaType == TeaType.Black)
            {
                totalPrice += amount * 4.50;
            }
            else if (teaType == TeaType.Green)
            {
                totalPrice += amount * 5.25;
            }           

            return totalPrice;
        }
    }
}
