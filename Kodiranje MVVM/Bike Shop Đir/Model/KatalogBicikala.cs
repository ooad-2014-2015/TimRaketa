using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class KatalogBicikala
    {
        int brojBicikala { get; set; }
        private List<BicikloPredefinisano> biciklaUPonudi;
        public List<BicikloPredefinisano> BiciklaUPonudi
        {
            get { return biciklaUPonudi; }
            set { biciklaUPonudi = value; }
        }

        public KatalogBicikala()
        {
            biciklaUPonudi = new List<BicikloPredefinisano>();

        }

        void obrisiBiciklo(string idBicikla)
        {
            biciklaUPonudi.Remove(biciklaUPonudi.Single(x => x.idBicikla == idBicikla));
        }

        void prikaziBicikla()
        {

        }

        /*void prikaziBicikla(TipBicikla tip)
        {
            foreach (BicikloPredefinisano b in biciklaUPonudi)
                if (b.tipBicikla == tip) return; //...
        }*/


    }
}
