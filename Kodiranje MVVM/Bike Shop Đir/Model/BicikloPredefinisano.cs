using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public class BicikloPredefinisano : Biciklo
    {
        string dodatniOpis { get; set; }
        string nazivProizvodjaca { get; set; }
        int godinaProizvodnje { get; set; }
        float cijena { get; set; }

        public BicikloPredefinisano()
        {

        }

        public override float izracunajCijenu()
        {
            return cijena;
        }



    }
}
