using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Korpa
    {
        private string idKorpe { get; set; }

        private Klijent klijent { get; set; }

        private float ukupnaCijena;

        public float UkupnaCijena
        {
            get { return ukupnaCijena; }
            set { ukupnaCijena = value; }
        }

        private DateTime vrijemeKupovine;

        public DateTime VrijemeKupovine
        {
            get { return vrijemeKupovine; }
            set { vrijemeKupovine = value; }
        }

        private int brojStavki;

        public int BrojStavki
        {
            get { return brojStavki; }
            set { brojStavki = value; }
        }

        public Korpa()
        {

        }

        void obnoviCijenu(int cijena)
        { //dodati cijenu nove stavke na postojecu
        }

        int vratiBrojStavki()
        { //neki count
        }

        void dodajStavku(StavkaKorpe novaStavka)
        { //neki add u bazu
        }

        void prikaziSadrzajKorpe
        { // ???
        }

    }
}
