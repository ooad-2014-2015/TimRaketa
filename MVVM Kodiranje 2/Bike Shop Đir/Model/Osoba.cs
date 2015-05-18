using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Osoba
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private DateTime datumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        private string adresaStanovanja;

        public string AdresaStanovanja
        {
            get { return adresaStanovanja; }
            set { adresaStanovanja = value; }
        }


        string vratiImeIPrezime()
        {
            return (this.Ime + " " + this.Prezime);
        }




    }
}
