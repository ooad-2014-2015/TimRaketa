using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bike_Shop_Đir.BazaTableAdapters;
using System.Collections.ObjectModel;

namespace Bike_Shop_Đir.Model
{
    class KatalogBicikala
    {
        int brojBicikala { get; set; }
        ObservableCollection<BicikloPredefinisano> biciklaUPonudi;

        public KatalogBicikala()
        {
            biciklaUPonudi = new ObservableCollection<BicikloPredefinisano>();

        }

        void obrisiBiciklo(int idBicikla)
        {
            KATALOG_BICIKALATableAdapter adapter = new KATALOG_BICIKALATableAdapter();
            adapter.DeleteBiciklo(idBicikla);
        }

        object prikaziBicikla()
        {
            KATALOG_BICIKALATableAdapter adapter = new KATALOG_BICIKALATableAdapter();
            Baza.KATALOG_BICIKALADataTable tabela;
            tabela = adapter.DajBicikla();
            return tabela;

        }

       


    }
}
