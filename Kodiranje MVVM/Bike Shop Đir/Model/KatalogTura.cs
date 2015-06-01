using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bike_Shop_Đir.BazaTableAdapters;

namespace Bike_Shop_Đir.Model
{
    class KatalogTura
    {
        static int brojTura;
        private List<Tura> tureUPonudi;
        public List<Tura> TureUPonudi
        {
            get { return tureUPonudi; }
            set { tureUPonudi = value; }
        }

        public KatalogTura()
        {
            tureUPonudi = new List<Tura>();
        }

        void dodajTuru(Tura novaTura)
        {
            tureUPonudi.Add(novaTura);
            KATALOG_TURATableAdapter tureAdapter = new KATALOG_TURATableAdapter();
            Baza.KATALOG_TURADataTable tabela;
            tabela = tureAdapter.DajTure();
            

        }

        void obrisiTuru(string idTure)
        {
            tureUPonudi.Remove(tureUPonudi.Single(x => x.idTure == idTure));

        }
    }
}
