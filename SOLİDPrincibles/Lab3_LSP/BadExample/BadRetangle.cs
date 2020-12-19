using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab3_LSP.BadExample
{
    //Ata sınıf
    public class BadRetangle
    {
        //kötü senaryomuzda ata sınıfımız olan BadRetangle sınıfmızın üyeleirni virtuall olarak işaretledikki onları alt sınıflarda override edebilelim.
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
