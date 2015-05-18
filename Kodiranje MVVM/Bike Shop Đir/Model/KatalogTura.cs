using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class KatalogTura
    {
        static int brojTura;
        List<Tura> tureUPonudi;

        public KatalogTura()
        {
            tureUPonudi = new List<Tura>();
        }

        void dodajTuru(Tura novaTura)
        {
            tureUPonudi.Add(novaTura);
        }

        void obrisiTuru(string idTure)
        {
            tureUPonudi.Remove(tureUPonudi.Single(x => x.idTure == idTure));

        }
    }
}
