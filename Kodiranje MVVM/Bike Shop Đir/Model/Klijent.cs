using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Bike_Shop_Đir.BazaTableAdapters;

namespace Bike_Shop_Đir.Model
{
    // Upitno mi je jesmo li trebali razdvojiti kreditnu karticu kao zasebnu klasu...
    public class Klijent : Osoba, IDataErrorInfo
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value;}
        }

        private string sifra;

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }

        private int brojKartice;

        public int BrojKartice
        {
            get { return brojKartice; }
            set { brojKartice = value; }
        }

        public Klijent()
        {

        }

        void promijeniSifru(string novaSifra)
        {
          //  KLIJENTITableAdapter adapter = new KLIJENTITableAdapter();
          //  Baza.KLIJENTIDataTable tabela;
          //  tabela = adapter.DajPoSifri(this.sifra);
            this.Sifra = novaSifra;
          //  adapter.Update(tabela);
            
        }

        void promijeniBrojKartice(int noviBroj)
        {
            this.brojKartice = noviBroj;
        }


        public bool provjeriPostojanje()
        {
            //provjeriti u bazi da li postoji korisnik, preko "this.username" ;
            return true;
        }

        public void upisiUBazu()
        {
           // KLIJENTITableAdapter adapter = new KLIJENTITableAdapter();
          //  adapter.Insert(this.Ime, this.Prezime, this.AdresaStanovanja, this.UserName, this.Sifra, Convert.ToInt32(34234));
            return;
        }

        //ovdje počinje validacija
        /// >>>>>>>>>>>>
        /// >>>>>>>>>>>>
        /// >>>>>>>>>>>>
        
        private string validirajDatum()
        {
            //Test za datum
            if (DatumRodjenja >= DateTime.Now)
            {
                return "Unesite datum u prošlosti!";
            }
            return null;
        }

        private string validirajIme()
        {
            //Prvo gleda jel vrijednost uopste poputnjena
            if (String.IsNullOrWhiteSpace(Ime))
            {
                return "Ime mora biti uneseno!";
            }

            if (Ime.Length < 2)
            {
                return "Ime prekratko";
            }
            return null;
        }

        private string validirajPrezime()
        {
            //Prvo gleda jel vrijednost uopste poputnjena
            if (String.IsNullOrWhiteSpace(Prezime))
            {
                return "Ime mora biti uneseno!";
            }

            if (Prezime.Length < 2)
            {
                return "Ime prekratko";
            }
            return null;
        }

        private string validirajBroj()
        {
            if (String.IsNullOrWhiteSpace(BrojKartice.ToString()))
            {
                return "Broj kreditne kartice mora biti unesen!";
            }
            if (BrojKartice.ToString().Length > 19 || BrojKartice.ToString().Length < 11)
            {
                return "Broj kreditne kartice ne postoji!";
            }
            return null;
        }

        string getValidationError(string propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "DatumRodjenja":
                    error = validirajDatum();
                    break;
                case "Ime":
                    error = validirajIme();
                    break;
                case "Prezime":
                    error = validirajPrezime();
                    break;
                case "BrojKartice":
                    error = validirajBroj();
                    break;

            }
            return error;
        }

        string IDataErrorInfo.this[string propertyName]
        {
            get { return getValidationError(propertyName); }
        }

        string IDataErrorInfo.Error
        {
            get { return null; }
        }

        static readonly string[] validateProperties =
        {
            "DatumRodjenja","Ime","Prezime","BrojKartice"
        };

        public bool IsValid
        {
            get
            {
                foreach (string property in validateProperties)
                {
                    if (getValidationError(property) != null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
