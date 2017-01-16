using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class LastMinute: Podroz
    {
        override public double KosztPoRabacie()
        {
            return koszt*0.5;
        }
        public override string ToString()
        {
            return base.ToString() + "LastMinute";
        }
    }
}
