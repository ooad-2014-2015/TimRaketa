using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Zaposlenik : Osoba
    {
        private string idZaposlenika;

        public string IdZaposlenika
        {
            get { return idZaposlenika; }
            set { idZaposlenika = value; }
        }

        private float satnica;

        public float Satnica
        {
            get { return satnica; }
            set { satnica = value; }
        }

        private float plata;

        public float Plata
        {
            get { return plata; }
            set { plata = value; }
        }

        enum TipZaposlenika { Serviser, Vodic, Prodavac, Vlasnik }


        private TipZaposlenika tipZaposlenika;

       /* public TipZaposlenika TipZaposlenika
        {
            get { return tipZaposlenika; }
            set { tipZaposlenika = value; }
        }*/


        public Zaposlenik()
        {

        }

        TipZaposlenika vratiTip()
        {
            return this.tipZaposlenika;
        }


    }
}
