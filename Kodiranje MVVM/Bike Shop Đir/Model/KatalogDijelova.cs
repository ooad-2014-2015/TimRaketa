using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Bike_Shop_Đir.Model
{
    public class KatalogDijelova : INotifyPropertyChanged
    {
        private ObservableCollection<DioBicikla> dijeloviUPonudi;
        public ObservableCollection<DioBicikla> DijeloviUPonudi
        {
            get { return dijeloviUPonudi; }
            set { dijeloviUPonudi = value; OnPropertyChanged("DijeloviUPonudi"); }
        }
         

        public KatalogDijelova()
        {
           
           // SqlConnection veza = new SqlConnection("Data Source=TOPLAP;Initial Catalog=BikeShopGir;Integrated Security=True");
            dijeloviUPonudi = new ObservableCollection<DioBicikla>();
        }

        void dodajDio(DioBicikla dio)
        {
            
            dijeloviUPonudi.Add(dio);
        }

        
        
        void obrisiDio(string id)
        {

            dijeloviUPonudi.Remove(dijeloviUPonudi.Single(x => x.IDDijela == id));
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
