using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
//using Bike_Shop_Đir.BazaTableAdapters;

namespace Bike_Shop_Đir.Model
{
    public class KatalogTura : INotifyPropertyChanged
    {
        static int brojTura;
        private ObservableCollection<Tura> tureUPonudi;
        public ObservableCollection<Tura> TureUPonudi
        {
            get { return tureUPonudi; }
            set { tureUPonudi = value; OnPropertyChanged("TureUPonudi"); }
        }

        public KatalogTura()
        {
            tureUPonudi = new ObservableCollection<Tura>();
        }

        void dodajTuru(Tura novaTura)
        {
            tureUPonudi.Add(novaTura);
            //KATALOG_TURATableAdapter tureAdapter = new KATALOG_TURATableAdapter();
            //Baza.KATALOG_TURADataTable tabela;
          //  tabela = tureAdapter.DajTure();
            

        }

        void obrisiTuru(string idTure)
        {
            tureUPonudi.Remove(tureUPonudi.Single(x => x.idTure == idTure));

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
