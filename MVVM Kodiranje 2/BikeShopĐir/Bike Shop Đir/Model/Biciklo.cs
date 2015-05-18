using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    abstract class Biciklo
    {
        public string idBicikla { get; set; }
        public TipBicikla tipBicikla { get; set; }


        private float cijena;

        public float Cijena
        {
            get { return cijena; }
            set { cijena = 0; }
        }


        public abstract float izracunajCijenu();
    }
}
