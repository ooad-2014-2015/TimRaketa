using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Tura
    {
        public string idTure { get; set; }

        string nazivTure { get; set; }

        float trajanje { get; set; }

        float duzina { get; set; }

        TipTure tipTure { get; set; }

        int tezina { get; set; }

        bool rentBicikla { get; set; }

        Zaposlenik vodic { get; set; }

        List<Klijent> klijenti;

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
