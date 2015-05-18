using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    abstract class Usluga
    {
        private float cijenaUsluge;

        public float CijenaUsluge
        {
            get { return cijenaUsluge; }
            set { cijenaUsluge = 0; }
        }

    }
}
