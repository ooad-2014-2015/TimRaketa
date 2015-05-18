using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class KatalogDijelova
    {
        List<DioBicikla> dijeloviUPonudi;


        public KatalogDijelova()
        {
            dijeloviUPonudi = new List<DioBicikla>();
        }

        void dodajDio(DioBicikla dio)
        {
            dijeloviUPonudi.Add(dio);
        }

        void obrisiDio(string id)
        {
            dijeloviUPonudi.Remove(dijeloviUPonudi.Single(x => x.idDijela == id));
        }
    }
}
