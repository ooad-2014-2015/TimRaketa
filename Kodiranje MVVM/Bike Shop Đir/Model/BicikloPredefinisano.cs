﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bike_Shop_Đir.Model
{
    public class BicikloPredefinisano : Biciklo
    {
        private string dodatniOpis;
        public string DodatniOpis
        {
            get {return dodatniOpis; }
            set { dodatniOpis = value; OnPropertyChanged("DodatniOpis"); }
        }

        private Image slika;
        public Image Slika
        {
            get { return slika; }
            set { slika = value; OnPropertyChanged("Slika"); }
        }

        private string nazivProizvodjaca; 
        public string NazivProizvodjaca
        {
            get { return nazivProizvodjaca; }
            set { nazivProizvodjaca = value; OnPropertyChanged("NazivProizvodjaca"); }
        }

        private int godinaProizvodnje;
        public int GodinaProizvodnje
        {
            get { return godinaProizvodnje; }
            set { godinaProizvodnje = value; OnPropertyChanged("GodinaProizvodnje"); }
        }

        public BicikloPredefinisano()
        {

        }

        public override float izracunajCijenu()
        {
            return CijenaUsluge;
        }



    }
}
