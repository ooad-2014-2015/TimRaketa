using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Bike_Shop_Đir.Model;
using Bike_Shop_Đir.View;

namespace Bike_Shop_Đir.ViewModel
{
    public class NarucivanjeServisViewModel
    {
        private Servis servis;
        public Servis Servis
        {
            get { return servis; }
            set { servis = value; }
        }

        public ICommand Naruci { get; set; }

        public NarucivanjeServisViewModel()
        {
            servis = new Servis();
            Naruci = new RelayCommand(naruci);
        }

        public Action CloseAction { get; set; }

        public void naruci(object parametar)
        {
            uBazu(servis);
            CloseAction();
        }

        private void uBazu(Servis pServis)
        {
            //dodavanje novog servisa u bazu
        }
    }
}
