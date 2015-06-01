﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public class BicikloPredefinisano : Biciklo
    {
        private string dodatniOpis;
        public string DodatniOpis
        {
            get {return dodatniOpis; }
            set {dodatniOpis = value; }
        }

        private string nazivProizvodjaca; 
        public string NazivProizvodjaca
        {
            get { return nazivProizvodjaca; }
            set { nazivProizvodjaca = value; }
        }

        private int godinaProizvodnje;
        public int GodinaProizvodnje
        {
            get { return godinaProizvodnje; }
            set { godinaProizvodnje = value; }
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
