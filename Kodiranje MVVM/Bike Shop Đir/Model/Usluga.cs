using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public abstract class Usluga : INotifyPropertyChanged
    {
        private float cijenaUsluge;
        public float CijenaUsluge
        {
            get { return cijenaUsluge; }
            set { cijenaUsluge = 0; }
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
