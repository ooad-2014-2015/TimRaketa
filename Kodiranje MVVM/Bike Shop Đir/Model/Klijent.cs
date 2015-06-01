﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Bike_Shop_Đir.BazaTableAdapters;

namespace Bike_Shop_Đir.Model
{
    // Upitno mi je jesmo li trebali razdvojiti kreditnu karticu kao zasebnu klasu...
    public class Klijent : Osoba
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


    }
}
