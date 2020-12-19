using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLİDPrincibles.Lab3_LSP.GoodExample.Abstract
{
    public abstract class Shape
    {
        //Bu prensibe ters düşmemek adına ve ata sınıfların amacından şaşmamak için ortak özellikler burada depolanacak

        public int Id { get; set; }

        public int Edge { get; set; }
    }
}
