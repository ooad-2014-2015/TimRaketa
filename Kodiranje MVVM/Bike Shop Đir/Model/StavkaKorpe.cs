using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace Bike_Shop_Đir.Model
{
    public class StavkaKorpe : INotifyPropertyChanged
    {
        static int redniBroj = 0;

        private int kolicina;
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; OnPropertyChanged("Kolicina"); }
        }

        private Usluga tipUsluge;
        public Usluga TipUsluge
        {
            get { return tipUsluge; }
            set { tipUsluge = value; }
        }

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
