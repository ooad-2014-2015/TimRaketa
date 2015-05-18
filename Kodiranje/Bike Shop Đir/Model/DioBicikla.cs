using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class DioBicikla
    {
        public string idDijela { get; set; }
        string nazivProizvodjaca { get; set; }
        int godinaProizvodnje { get; set; }
        string dodatniOpis { get; set; }
        public float cijenaDijela { get; set; }

        enum Komponente { Amortizer, Headset, Gripovi, Kocnice, Lula, Lanac, Mjenjac, Pedale, Pogon, Ram, Sjediste, Tockovi, Guvernala, Zupcanik, Zatezac }
       
        Komponente vrstaKomponente;

        public DioBicikla()
        {
        }

    }
}
