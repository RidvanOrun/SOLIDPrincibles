using SOLİDPrincibles.Lab4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab4_ISP.GoodExample.Concrete
{
    public class Salmon : ISwimGillFish
    {
        public string Gill()
        {
            throw new NotImplementedException();
        }

        public string Swim()
        {
            throw new NotImplementedException();
        }
    }
}
