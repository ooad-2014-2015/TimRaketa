﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    // Upitno mi je jesmo li trebali razdvojiti kreditnu karticu kao zasebnu klasu...
    public class Klijent : Osoba, INotifyPropertyChanged 
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; OnPropertyChanged("UserName"); }
        }

        private string sifra;

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; OnPropertyChanged("Sifra"); }
        }

        private int brojKartice;

        public int BrojKartice
        {
            get { return brojKartice; }
            set { brojKartice = value; OnPropertyChanged("BrojKartice"); }
        }

        public Klijent()
        {

        }

        void promijeniSifru(string novaSifra)
        {
            this.Sifra = novaSifra;
        }

        void promijeniBrojKartice(int noviBroj)
        {
            this.BrojKartice = noviBroj;
        }


        public bool provjeriPostojanje()
        {
            //provjeriti u bazi da li postoji korisnik, preko "this.username" ;
            return true;
        }

        public void upisiUBazu()
        {
            //validacija pa upis
            return;
        }

    }
}
