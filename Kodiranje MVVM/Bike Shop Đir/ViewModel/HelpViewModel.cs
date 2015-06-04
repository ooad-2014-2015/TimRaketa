using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Xps.Packaging;

namespace Bike_Shop_Đir.View
{
    class HelpViewModel : INotifyPropertyChanged
    {
        private XpsDocument xps;

        public XpsDocument Xps
        {
            get { return xps; }
            set { xps = value; OnPropertyChanged("xps"); }
        }
        
        public HelpViewModel(DocumentViewer d)
        {
            Xps = new XpsDocument(@"D:\FAKS\OOAD\GIT\TimRaketa\Kodiranje MVVM\Bike Shop Đir\HELP.xps", System.IO.FileAccess.Read);
            d.Document = Xps.GetFixedDocumentSequence();
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
