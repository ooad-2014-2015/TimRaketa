using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class BicikloIzDijelova : Biciklo
    {
        List<DioBicikla> listaDijelova;

        public BicikloIzDijelova()
        {

        }

        public override void izracunajCijenu()
        {
            foreach (DioBicikla d in listaDijelova)
            {
                this.Cijena += d.cijenaDijela;
            }
        }
    }
}
