using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;

namespace Bike_Shop_Đir.ViewModel
{
    class OdabirBiciklaViewModel
    {
        private KatalogBicikala bicikla;
        public KatalogBicikala Bicikla
        {
            get { return bicikla; }
            set { bicikla = value; }
        }

        private KatalogDijelova dijelovi;
        public KatalogDijelova Dijelovi
        {
            get { return dijelovi; }
            set { dijelovi = value; }
        }

        public OdabirBiciklaViewModel()
        {
            bicikla = new KatalogBicikala();
            dijelovi = new KatalogDijelova();
            povuciIzBazeBicikla();
            povuciIzBazeDijelove();
        }

        public void povuciIzBazeBicikla()
        {
            //ovdje ćemo u instancu kataloga povući bicikla
        }

        public void povuciIzBazeDijelove()
        {
            //ovdje ćemo u instancukataloga povući dijelove
        }
    }
}
