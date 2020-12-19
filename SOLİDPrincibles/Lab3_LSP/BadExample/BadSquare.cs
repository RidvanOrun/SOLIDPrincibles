using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab3_LSP.BadExample
{
    //Burada BadSquare.cs sınıfımız BadRetangle sınıfımızdan kalıtım aldığında LSP prensibine ters düştük. Neden? Çünkü, bu prensip bizlere alt sınıfların üst sınıflarda yer değiştirilebilir olması gerektiğini söylemektedir. Buaraki senaryoyu teorik bilgimizdeki boksör olmak isteyen çiftçi oğluna benzetiriz.
    public class BadSquare
    {
        int _height;
        int _width;

        public override int Height
        {
            get => _height;
            set => _height = value;
        }

        public override int Width
        {
            get => _width;
            set => _width = value;
        }

    }
}
