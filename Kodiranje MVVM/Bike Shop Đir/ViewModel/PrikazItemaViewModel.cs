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
    public class PrikazItemaViewModel
    {
        private GlavnaFormaViewModel glavna;
        public GlavnaFormaViewModel Glavna
        {
            get { return glavna; }
            set { glavna = value; }
        }

        private BicikloPredefinisano bajk;
        public BicikloPredefinisano Bajk
        {
            get { return bajk; }
            set { bajk = value; }
        }

        public ICommand Kupi { get; set; }
        public ICommand Brisi { get; set; }

        public PrikazItemaViewModel(BicikloPredefinisano pBajk)
        {
            bajk = pBajk;
            Kupi = new RelayCommand(kupi);
            Brisi = new RelayCommand(brisi);
        }

        public Action CloseAction { get; set; }

        public void kupi(object parametar)
        {
            CloseAction();
        }

        public void brisi(object parametar)
        {

        }

    }
}
