using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab3_LSP.BadExample
{
    public class BadAreaCalculator
    {
        public static double CalculateArea(BadRetangle badRetangle)
        {
            return badRetangle.Height * badRetangle.Width;
        }

        public static double CalculateArea(BadSquare badSquare)
        {
            //ters düştük neden yanlış atadan gereksiz özellikleir kalıtım aldığından karenin uzunluğu olmaz.
            return badSquare.Height * badSquare.Width;
        }
    }
}
