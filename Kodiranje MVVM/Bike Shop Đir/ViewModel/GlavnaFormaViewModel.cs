using Bike_Shop_Đir.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bike_Shop_Đir.ViewModel
{
    class GlavnaFormaViewModel
    {
        ICommand RegistracijaILogovanje { get; set; }

        FormaRegistracijaILoginView formaRegistracija { get; set; }

        RegistracijaViewModel dijeteRegistracijaViewModel { get; set; }

        public GlavnaFormaViewModel()
        {
            RegistracijaILogovanje = new RelayCommand(registracijaILogovanjeKlik);
        }

        public void registracijaILogovanjeKlik(object parametar)
        {
            formaRegistracija = new FormaRegistracijaILoginView();
            dijeteRegistracijaViewModel = new RegistracijaViewModel(this);

            formaRegistracija.Show();
        }
    }
}
