using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public abstract class Biciklo : Usluga
    {
        private string idBicikla;
        public string IDBicikla
        {
            get { return idBicikla; }
            set { idBicikla = value; }
        }



        public abstract float izracunajCijenu();
    }
}
