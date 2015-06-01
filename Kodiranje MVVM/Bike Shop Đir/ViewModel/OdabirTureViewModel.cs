using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;
using System.Windows.Input;
using System.ComponentModel;

namespace Bike_Shop_Đir.ViewModel
{
    public class OdabirTureViewModel : INotifyPropertyChanged
    {
        private KatalogTura ture;
        public KatalogTura Ture
        {
            get { return ture; }
            set { ture = value; OnPropertyChanged("Ture"); }
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
