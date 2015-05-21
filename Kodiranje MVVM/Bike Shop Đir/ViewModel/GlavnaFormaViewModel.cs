using Bike_Shop_Đir.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bike_Shop_Đir.ViewModel
{
    internal class GlavnaFormaViewModel : INotifyPropertyChanged
    {
        public ICommand RegistracijaILogovanje { get; set; }

        FormaRegistracijaILoginView formaRegistracija;        
        public FormaRegistracijaILoginView FormaRegistracija
        {
            get { return formaRegistracija; }
            set { formaRegistracija = value; }
        }

        RegistracijaViewModel dijeteRegistracijaViewModel;
        public RegistracijaViewModel DijeteRegistracijaViewModel
        {
          get { return dijeteRegistracijaViewModel; }
          set { dijeteRegistracijaViewModel = value; }
        }
        
        
        
        public GlavnaFormaViewModel()
        {
            RegistracijaILogovanje = new RelayCommand(registracijaILogovanjeKlik);
            DijeteRegistracijaViewModel = new RegistracijaViewModel(this);
        }

        public void registracijaILogovanjeKlik(object parametar)
        {
            FormaRegistracija = new FormaRegistracijaILoginView();

       //     FormaRegistracija.DataContext = DijeteRegistracijaViewModel;
          

            FormaRegistracija.Show();
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
