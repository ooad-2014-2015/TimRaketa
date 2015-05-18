using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Korpa : INotifyPropertyChanged
    {
        private string idKorpe { get; set; }

        ObservableCollection<StavkaKorpe> stavke;

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
            stavke = new ObservableCollection<StavkaKorpe>();
        }

        void obnoviCijenu(int cijena)
        { //dodati cijenu nove stavke na postojecu
        }

        int vratiBrojStavki()
        { //neki count
            return 0;
        }

        void dodajStavku(StavkaKorpe novaStavka)
        { //neki add u bazu
        }

        void prikaziSadrzajKorpe
        { // ???
        }

    }
}
