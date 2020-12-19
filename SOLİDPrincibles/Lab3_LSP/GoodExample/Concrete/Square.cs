using SOLİDPrincibles.Lab3_LSP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab3_LSP.GoodExample.Concrete
{
    public class Square: Shape
    {
        public double SquareArea()
        {
            return Edge * Edge;
        }
    }
}
