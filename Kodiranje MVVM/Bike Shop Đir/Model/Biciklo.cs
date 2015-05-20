using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    abstract class Biciklo : Usluga
    {
        public string idBicikla { get; set; }

        enum TipBicikla { Brdsko, Cestovno, Downhill, Bmx, Rekreacijsko }
        
      //  public TipBicikla tipBicikla { get; set; }


        public abstract float izracunajCijenu();
    }
}
