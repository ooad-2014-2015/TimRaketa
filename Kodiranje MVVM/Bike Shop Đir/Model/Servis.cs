using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Shop_Đir.Model
{
    public class Servis : Usluga, INotifyPropertyChanged
    {
        public enum statusServisa { AnalizaKvara, Servisiranje, NaCekanju, Popravljen};

        public static string ID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string opisProblema;
        public string OpisProblema
        {
            get { return opisProblema; }
            set { opisProblema = value; OnPropertyChanged("OpisProblema"); }
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


        public void upisiUBazu()
        {
            //dodijeliti mu ID i upisati...
            return;
        }

    }
}
