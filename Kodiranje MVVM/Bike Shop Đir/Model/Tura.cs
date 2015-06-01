using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public class Tura : Usluga
    {
        public enum TipTure { Gradska, Brdska, Mjesovita, Utrka }

        private string idTure;
        public string IDTure
        {
            get { return idTure; }
            set { idTure = value; }
        }

        private string nazivTure;
        public string NazivTure
        {
            get { return nazivTure; }
            set { nazivTure = value; }
        }

        private float trajanje;
        public float Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }

        private float duzina;
        public float Duzina
        {
            get { return duzina; }
            set { duzina = value; }
        }

        private TipTure tipTure;
        public TipTure TipTureI
        {
            get { return tipTure; }
            set { tipTure = value; }
        }

        private int tezina;
        public int Tezina
        {
            get { return tezina; }
            set { tezina = value; }
        }

        private bool rentBicikla;
        public bool RentBicikla
        {
            get { return rentBicikla; }
            set { rentBicikla = value; }
        }

        private Zaposlenik vodic;
        public Zaposlenik Vodic
        {
            get { return vodic; }
            set { vodic = value; }
        }

        private List<Klijent> klijenti;
        public List<Klijent> Klijenti
        {
            get { return klijenti; }
            set { klijenti = value; }
        }

        public Tura()
        {
            klijenti = new List<Klijent>();
        }

        // sve metore "promijeni...." su mi upitne zelimo li ih
        public void promijeniDuzinu(float novaDuzina)
        {
            this.duzina = novaDuzina;
        }

        public void promijeniTrajanje(float novoTrajanje)
        {
            this.trajanje = novoTrajanje;
        }

        public void promijeniTezinu(int novaTezina)
        {
            this.tezina = novaTezina;
        }

    }
}
