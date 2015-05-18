using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class StavkaKorpe
    {
        static int redniBroj = 0;

        private int kolicina;

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        Usluga tipUsluge;

        private float trenutnaCijena;

        public float TrenutnaCijena
        {
            get { return tipUsluge.CijenaUsluge * kolicina; }
            set { trenutnaCijena = value; }
        }

     /*   enum TipUsluge { KupovinaBicikla, Servis, Tura }

        public TipUsluge tipUsluge { get; set; }*/


        public StavkaKorpe()
        {

        }



        
        


    }
}
