using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public class Korpa : INotifyPropertyChanged
    {
        private string idKorpe { get; set; }

        private ObservableCollection<StavkaKorpe> stavke;
        public ObservableCollection<StavkaKorpe> Stavke
        {
            get { return stavke; }
            set { stavke = value; OnPropertyChanged("Stavke"); }
        }

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

    /*    void prikaziSadrzajKorpe
        { // ???
        }
     
     */


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
