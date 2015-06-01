using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Bike_Shop_Đir.Model
{
    public class KatalogBicikala : INotifyPropertyChanged
    {
        int brojBicikala { get; set; }
        private ObservableCollection<BicikloPredefinisano> biciklaUPonudi;
        public ObservableCollection<BicikloPredefinisano> BiciklaUPonudi
        {
            get { return biciklaUPonudi; }
            set { biciklaUPonudi = value; OnPropertyChanged("BiciklaUPonudi"); }
        }

        public KatalogBicikala()
        {
            biciklaUPonudi = new ObservableCollection<BicikloPredefinisano>();

        }

        void obrisiBiciklo(string idBicikla)
        {
            biciklaUPonudi.Remove(biciklaUPonudi.Single(x => x.idBicikla == idBicikla));
        }

        void prikaziBicikla()
        {

        }

        /*void prikaziBicikla(TipBicikla tip)
        {
            foreach (BicikloPredefinisano b in biciklaUPonudi)
                if (b.tipBicikla == tip) return; //...
        }*/

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
