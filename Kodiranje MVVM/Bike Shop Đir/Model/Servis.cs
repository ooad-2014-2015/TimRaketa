using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    class Servis : Usluga, INotifyPropertyChanged
    {
        public enum statusServisa { AnalizaKvara, Servisiranje, NaCekanju, Popravljen};

        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string opisProblema;
        public string OpisProblema
        {
            get { return opisProblema; }
            set { opisProblema = value; }
        }

        private statusServisa status;
        public statusServisa Status
        {
            get { return status; }
            set { status = value; }
        }

        public void promijeniStatus(statusServisa pstatus)
        {
            status = pstatus;
        }

        public void promijeniCijenu(float pcijena)
        {
            CijenaUsluge = pcijena;
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
