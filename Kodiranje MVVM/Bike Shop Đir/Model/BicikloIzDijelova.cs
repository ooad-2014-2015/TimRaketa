using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public override float izracunajCijenu()
        {
            foreach (DioBicikla d in listaDijelova)
            {
                this.CijenaUsluge += d.cijenaDijela;
            }
            return this.CijenaUsluge;
        }
    }
}
