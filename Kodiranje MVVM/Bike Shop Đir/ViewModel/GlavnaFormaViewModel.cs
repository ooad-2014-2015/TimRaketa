using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using bsd = Bike_Shop_Đir;

namespace Bike_Shop_Đir.ViewModel
{
    public class GlavnaFormaViewModel : INotifyPropertyChanged
    {
        public ICommand RegistracijaILogovanje { get; set; }

        FormaRegistracijaILoginView formaRegistracija;        
        public FormaRegistracijaILoginView FormaRegistracija
        {
            get { return formaRegistracija; }
            set { formaRegistracija = value; }
        }

        private Klijent noviKlijent;
        public Klijent NoviKlijent
        {
            get { return noviKlijent; }
            set { noviKlijent = value; }
        }


    /*    RegistracijaViewModel dijeteRegistracijaViewModel;
        public RegistracijaViewModel DijeteRegistracijaViewModel
        {
          get { return dijeteRegistracijaViewModel; }
          set { dijeteRegistracijaViewModel = value; }
        }*/

        public static Klijent prijavljeni { get; set; }
        

        public GlavnaFormaViewModel()
        {
            prijavljeni = null;
          //  NoviKlijent = new Klijent();
            RegistracijaILogovanje = new RelayCommand(registracijaILogovanjeKlik);
          //  DijeteRegistracijaViewModel = new RegistracijaViewModel(this);
            
        }

        public void registracijaILogovanjeKlik(object parametar)
        {
            FormaRegistracija = new FormaRegistracijaILoginView();
            //FormaRegistracija.DataContext = this;
            FormaRegistracija.Visibility = Visibility.Visible;
        
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
