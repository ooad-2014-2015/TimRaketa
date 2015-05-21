using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Osoba : INotifyPropertyChanged
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; OnPropertyChanged("Ime"); }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; OnPropertyChanged("Prezime");  }
        }

        private DateTime datumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; OnPropertyChanged("DatumRodjenja"); }
        }

        private string adresaStanovanja;

        public string AdresaStanovanja
        {
            get { return adresaStanovanja; }
            set { adresaStanovanja = value; OnPropertyChanged("Adresa") }
        }


        string vratiImeIPrezime()
        {
            return (this.Ime + " " + this.Prezime);
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
