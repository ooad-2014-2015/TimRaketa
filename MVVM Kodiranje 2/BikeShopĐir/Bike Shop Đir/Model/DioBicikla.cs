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
        Komponente vrsta { get; set; }
        int godinaProizvodnje { get; set; }
        string dodatniOpis { get; set; }
        public float cijenaDijela { get; set; }

        public DioBicikla()
        {

        }

    }
}
